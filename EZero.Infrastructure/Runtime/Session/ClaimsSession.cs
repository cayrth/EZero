using EZero.Infrastructure.Runtime.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace EZero.Infrastructure.Runtime.Session
{
    public class ClaimsSession : ISession
    {
        public ClaimsSession()
        {

        }

        public int UserId
        {
            get
            {
                var userIdClaim = ClaimsPrincipal.Current.Claims.FirstOrDefault(c => c.Type == BaseClaimTypes.UserID);
                if (string.IsNullOrEmpty(userIdClaim?.Value))
                {
                    return 0;
                }

                int userId;
                if (!int.TryParse(userIdClaim.Value, out userId))
                {
                    return 0;
                }

                return userId;
            }
        }

        public string UserName
        {
            get
            {

                var userIdClaim = ClaimsPrincipal.Current.Claims.FirstOrDefault(c => c.Type == BaseClaimTypes.UserName);
                if (string.IsNullOrEmpty(userIdClaim?.Value))
                {
                    return null;
                }

                return userIdClaim.Value;
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return UserId > 0;
            }
        }
    }
}
