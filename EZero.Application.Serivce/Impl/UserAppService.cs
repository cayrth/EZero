using EZero.Domain.Model;
using EZero.Domain.Model.Admin;
using EZero.EntityFrameworkCore.Repositories;
using EZero.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EZero.Application.Serivce.Impl
{
    public class UserAppService : ApplicationService, IUserAppService
    {

        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Sysuser> _sysuserRepository;

        public UserAppService(IRepository<User> userRepository, IRepository<Sysuser> sysuserRepository)
        {
            _userRepository = userRepository;
            _sysuserRepository = sysuserRepository;
        }

        public int GetUserInfo(int id)
        {
            var list = _sysuserRepository.GetAllList();
            var user = _sysuserRepository.FirstOrDefault(id);

            var sysuserSysroles = user.SysuserSysroles;

            var user2 = _sysuserRepository.GetAllIncluding(a => a.SysuserSysroles).FirstOrDefault(a => a.Id == id);

            return id;
        }
    }
}
