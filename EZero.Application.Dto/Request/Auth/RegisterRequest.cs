using System;
using System.Collections.Generic;
using System.Text;

namespace EZero.Application.Dto.Request.Auth
{
    public class RegisterRequest
    {
        public string RegisterName { get; set; }

        public string Password { get; set; }
    }
}
