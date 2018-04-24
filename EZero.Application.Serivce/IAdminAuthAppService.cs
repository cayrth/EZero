using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Application.Serivce
{
    public interface IAdminAuthAppService
    {
        bool UserLogin(string userName, string password);
    }
}
