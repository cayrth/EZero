using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace EZero.Admin.Controllers
{
    public class AuthController : Controller
    {

        #region
        private readonly 
        #endregion


        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password, string returnUrl)
        {
       

        }
    }
}