using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Domain.Model.Admin
{
    /// <summary>
    /// 系统角色权限
    /// </summary>
    public class SysroleSyspermission
    {
        public int SysroleId { get; set; }
        public Sysrole Sysrole { get; set; }

        public int SyspermissionId { get; set; }
        public Syspermission Syspermission { get; set; }
    }
}
