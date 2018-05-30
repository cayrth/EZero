using EZero.Application.Dto.Request.Auth;
using EZero.Domain.Model.Admin;
using EZero.EntityFrameworkCore.Repositories;
using EZero.Infrastructure.Application.Message;
using EZero.Infrastructure.Dependency;
using EZero.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EZero.Infrastructure.Domain.Uow;
using EZero.Application.Dto.Model.Auth;

namespace EZero.Application.Serivce.Impl
{
    public class AdminAuthAppService : ApplicationService, IAdminAuthAppService
    {
        private readonly IRepository<Sysuser> _sysuser;
        private readonly IUnitOfWork _unitOfWork;

        public AdminAuthAppService(IRepository<Sysuser> sysuser, IUnitOfWork unitOfWork)
        {
            _sysuser = sysuser;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AppResult UserRegister(RegisterRequest request)
        {
            var appResult = new AppResult();

            var registerName = request.RegisterName.Trim();

            var isExist = _sysuser.GetMany(a => a.LoginName == registerName).Any();
            if (isExist)
            {
                appResult.Fail("账户名已经存在！");
                return appResult;
            }

            var sysuser = new Sysuser(request.RegisterName, request.Password);

            _sysuser.Insert(sysuser);

            if (_unitOfWork.Commit() == 0)
            {
                appResult.Exception("用户注册失败");
            }

            appResult.Done();

            return appResult;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public AppResult<UserLoginInfoModel> UserLogin(LoginRequest request)
        {
            var appResult = new AppResult<UserLoginInfoModel>();

            var sysuser = _sysuser.FirstOrDefault(a => a.LoginName == request.LoginName);
            if (sysuser == null)
            {
                appResult.NotFound("账户未找到！");
                return appResult;
            }

            var isPassed = sysuser.CheckPassword(request.Password);
            if (!isPassed)
            {
                appResult.Fail("密码不正确！");
                return appResult;
            }

            appResult.Data = new UserLoginInfoModel()
            {
                Id = sysuser.Id,
                Name = sysuser.LoginName
            };
            appResult.Done();

            return appResult;
        }


    }
}
