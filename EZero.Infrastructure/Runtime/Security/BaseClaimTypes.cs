using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace EZero.Infrastructure.Runtime.Security
{
    public class BaseClaimTypes
    {
        /// <summary>
        /// UserId.
        /// Default: <see cref="ClaimTypes.Name"/>
        /// </summary>
        public const string UserName = ClaimTypes.Name;

        /// <summary>
        /// UserId.
        /// Default: <see cref="ClaimTypes.NameIdentifier"/>
        /// </summary>
        public const string UserID = ClaimTypes.NameIdentifier;
    }
}
