using EZero.Infrastructure.Dependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Application.Serivce
{
    public interface IUserAppService : ITransientDependency
    {
        int GetUserInfo(int id);
    }
}
