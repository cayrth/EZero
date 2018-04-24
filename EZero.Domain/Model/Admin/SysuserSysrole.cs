using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Domain.Model.Admin
{
    /// <summary>
    /// 系统用户角色
    /// </summary>
    public class SysuserSysrole
    {
        public int SysuserId { get; set; }
        public Sysuser Sysuser { get; set; }

        public int SysroleId { get; set; }
        public Sysrole Sysrole { get; set; }
    }
}
