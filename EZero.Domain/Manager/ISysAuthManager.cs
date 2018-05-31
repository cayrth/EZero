using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Domain.Manager
{
    public interface ISysAuthManager
    {
        bool SysUserRegister(string userName, string password);
    }
}
