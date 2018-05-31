using EZero.Application.Dto.Model.Auth;
using EZero.Application.Dto.Request.Auth;
using EZero.Infrastructure.Application.Message;
using EZero.Infrastructure.Dependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Application.Serivce
{
    public interface ISysAuthAppService : ITransientDependency
    {

        AppResult UserRegister(RegisterRequest request);

        AppResult<UserLoginInfoModel> UserLogin(LoginRequest request);
    }
}
