using EZero.Domain.Model.Admin.ValueObject;
using EZero.Infrastructure.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EZero.Domain.Model.Admin
{
    /// <summary>
    /// 系统权限
    /// </summary>
    public class Syspermission : AggregateRoot
    {
        /// <summary>
        /// 父Id
        /// </summary>
        public int? Pid { get; set; }

        /// <summary>
        /// 系统权限名称
        /// </summary>
        public string SyspermissionName { get; set; }

        /// <summary>
        /// 系统权限展示名称
        /// </summary>
        public string SyspermissionTitle { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int SerialNumber { get; set; }

        /// <summary>
        /// 是否是导航栏
        /// </summary>
        public bool IsNavigation { get; set; }

        /// <summary>
        /// 系统权限路由VO
        /// </summary>
        [NotMapped]
        public SyspermissionRouteVO SyspermissionRoute { get; set; }

        ///// <summary>
        ///// 区域
        ///// </summary>
        //private string SyspermissionRoute_Area
        //{
        //    get { return SyspermissionRoute.Area; }
        //    set { SyspermissionRoute = SyspermissionRoute.WithStreet(value); }
        //}

        ///// <summary>
        ///// 控制器
        ///// </summary>
        //private string SyspermissionRoute_Controller { get; set; }

        ///// <summary>
        ///// 事件
        ///// </summary>
        //private string SyspermissionRoute_Action { get; set; }


        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 系统权限
        /// </summary>
        public virtual Syspermission Parent { get; set; }

        /// <summary>
        /// 系统权限
        /// </summary>
        public virtual ICollection<Syspermission> Children { get; set; }

        /// <summary>
        /// 系统角色权限
        /// </summary>
        public ICollection<SysroleSyspermission> SysroleSyspermissions { get; set; }

        public Syspermission()
        {

        }
    }
}
