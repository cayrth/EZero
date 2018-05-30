using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Infrastructure.Runtime.Session
{
    public interface ISession
    {
        /// <summary>
        /// Gets current UserId or null.
        /// It can be null if no user logged in.
        /// </summary>
        int UserId { get; }

        /// <summary>
        /// Gets current UserName
        /// It can be null if no user logged in.
        /// </summary>
        string UserName { get; }

        bool IsAuthenticated { get; }
    }
}
