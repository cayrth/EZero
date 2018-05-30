using EZero.Infrastructure.Application.Message;
using EZero.Infrastructure.Runtime.Session;
using EZero.Infrastructure.Services.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Infrastructure.Services
{
    public abstract class ApplicationService
    {

        ///// <summary>
        ///// 工作单元
        ///// </summary>
        //public readonly IUnitOfWork UnitOfWork;

        /// <summary>
        /// Session
        /// </summary>
        public ISession Session { get; set; }

    }
}
