using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Infrastructure.Services.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class ModelValidationFilter : Attribute
    {
        public int Order { get; set; } = 1;

        public void OnProvidersExecuted(FilterProviderContext context)
        {
            var isValid = context.ActionContext.ModelState.IsValid;
        }

        public void OnProvidersExecuting(FilterProviderContext context)
        {
            var isValid = context.ActionContext.ModelState.IsValid;
        }
    }
}
