using EZero.Infrastructure.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Domain.Model.Admin
{
    /// <summary>
    /// 系统角色
    /// </summary>
    public class Sysrole : AggregateRoot
    {
        /// <summary>
        /// 系统角色名
        /// </summary>
        public string SysroleName { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int SerialNumber { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        
        public ICollection<SysroleSyspermission> SysroleSyspermissions { get; set; }

        public ICollection<SysuserSysrole> SysuserSysroles { get; set; }

        public Sysrole()
        {

        }
    }
}
