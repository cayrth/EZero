using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EZero.Infrastructure.Application.Message
{
    public enum ResultStatus
    {
        /// <summary>
        /// 失败
        /// </summary>
        [Description("执行失败")]
        Failed = 0,

        /// <summary>
        /// 成功
        /// </summary>
        [Description("执行成功")]
        Successed = 1,

        /// <summary>
        /// 未授权
        /// </summary>
        [Description("账户未授权")]
        Unauthorized = 2,

        /// <summary>
        /// 被禁止
        /// </summary>
        [Description("账户被禁止")]
        Forbidden = 3,

        /// <summary>
        /// 资源未找到
        /// </summary>
        [Description("资源未找到")]
        NotFound = 4,

        /// <summary>
        /// 服务器内部错误
        /// </summary>
        [Description("服务器内部错误")]
        Exception = 5,
    }
}
