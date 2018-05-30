using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EZero.Application.Dto.Request.Auth;
using EZero.Application.Serivce;
using EZero.Infrastructure.Runtime.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EZero.Admin.Controllers
{
    public class AuthController : Controller
    {

        private readonly IAdminAuthAppService _adminAuthAppService;

        public AuthController(IAdminAuthAppService adminAuthAppService)
        {
            _adminAuthAppService = adminAuthAppService;
        }

        [AllowAnonymous]
        //[HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {

            if (ModelState.IsValid)
            {

            }

            request.LoginName = "admin";
            request.Password = "123456";
            var appResult = _adminAuthAppService.UserLogin(request);

            if (appResult.Success)
            {
                var userLoginInfo = appResult.Data;

                var identity = BaseClaimsIdentity.CreateIdentity(AuthenticationTypes.AdminCookie, userLoginInfo.Id.ToString(), userLoginInfo.Name);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

                var returnUrl = request.ReturnUrl;
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }

                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            return View();
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var appResult = _adminAuthAppService.UserRegister(request);

            return Json(appResult);
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }

    }
}