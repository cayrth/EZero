using EZero.Domain.Model.Admin;
using EZero.EntityFrameworkCore.Repositories;
using EZero.Infrastructure.Domain.Uow;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Domain.Manager.Impl
{
    public class SysAuthManager: ISysAuthManager
    {
        #region 构造函数
        private readonly IRepository<Sysuser> _sysuser;
        private readonly IUnitOfWork _unitOfWork;

        public SysAuthManager(IRepository<Sysuser> sysuser, IUnitOfWork unitOfWork)
        {
            _sysuser = sysuser;
            _unitOfWork = unitOfWork;
        }
        #endregion

        /// <summary>
        /// 系统用户注册
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public bool SysUserRegister(string loginName, string password)
        {
            try
            {
                var sysuser = new Sysuser(loginName, password);
                _sysuser.Insert(sysuser);

                if (_unitOfWork.Commit() == 0)
                {
                    throw new Exception("用户注册失败");
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
