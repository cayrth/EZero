using EZero.Infrastructure.Dependency;
using EZero.Infrastructure.Runtime.Session;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Infrastructure.Services
{
    public interface IApplicationService : ITransientDependency
    {
        ISession Session { get; set; }
    }
}
