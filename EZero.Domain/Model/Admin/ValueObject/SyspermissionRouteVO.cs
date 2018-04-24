using EZero.Infrastructure.Domain.Values;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Domain.Model.Admin.ValueObject
{
    /// <summary>
    /// 系统权限路由VO
    /// </summary>
    public class SyspermissionRouteVO : ValueObject<SyspermissionRouteVO>
    {
        /// <summary>
        /// 区域
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 控制器
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// 事件
        /// </summary>
        public string Action { get; set; }
    }
}
