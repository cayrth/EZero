using EZero.Domain.Model.Admin;
using EZero.Infrastructure.Domain.Entities;
using EZero.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Domain.Model.Admin
{
    public class Sysuser : AggregateRoot
    {
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 密码Hash
        /// </summary>
        public string PassWordHash { get; set; }

        /// <summary>
        /// 盐随机码
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 系统用户角色
        /// </summary>
        public virtual ICollection<SysuserSysrole> SysuserSysroles { get; set; }

        public Sysuser()
        { }

        public Sysuser(string loginName, string password, string userName)
        {
            //if (string.IsNullOrEmpty(loginName))
            //{
            //    throw new BaseException("");
            //}

            LoginName = loginName;

            IsEnabled = true;
        }

   
    }
}
