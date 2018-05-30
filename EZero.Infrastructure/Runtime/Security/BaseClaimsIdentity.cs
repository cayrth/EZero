using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace EZero.Infrastructure.Runtime.Security
{
    public class BaseClaimsIdentity
    {
        public static ClaimsIdentity CreateIdentity(string authenticationType, string id, string name)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("Identity 值不能为空！");
            }

            ClaimsIdentity _identity = new ClaimsIdentity(authenticationType);
            _identity.AddClaim(new Claim(BaseClaimTypes.UserName, name));
            _identity.AddClaim(new Claim(BaseClaimTypes.UserID, id));
            _identity.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "ASP.NET Identity"));

            return _identity;
        }
    }
}
