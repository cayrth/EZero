using EZero.Domain.Model.Admin;
using EZero.Infrastructure.Domain.Entities;
using EZero.Infrastructure.Exceptions;
using EZero.Infrastructure.Runtime.Security;
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
        public string LoginName { get; private set; }

        /// <summary>
        /// 密码Hash
        /// </summary>
        public string PasswordHash { get; private set; }

        /// <summary>
        /// 盐随机码
        /// </summary>
        public string Salt { get; private set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        public bool IsEnabled { get; private set; }

        /// <summary>
        /// 系统用户角色
        /// </summary>
        public virtual ICollection<SysuserSysrole> SysuserSysroles { get; set; }

        private Sysuser()
        { }

        public Sysuser(string loginName, string password)
        {
            if (string.IsNullOrEmpty(loginName))
            {
                throw new BaseException("登录名不能为空");
            }
            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                throw new BaseException("登录名密码不能少于6位");
            }

            Salt = Guid.NewGuid().ToString();
            LoginName = loginName;
            PasswordHash = PasswordStrategy.CreateWithMD5(password + Salt + _passwordStr);
            IsEnabled = true;
        }

        /// <summary>
        /// 检查密码是否正确
        /// </summary>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public bool CheckPassword(string password)
        {
            return PasswordStrategy.CreateWithMD5(password + Salt + _passwordStr) == PasswordHash;
        }


        private const string _passwordStr = "%$EZero!@";
    }
}
