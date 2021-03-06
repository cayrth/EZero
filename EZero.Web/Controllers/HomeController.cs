﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EZero.Application.Serivce;
using EZero.Web.Models;
using Microsoft.AspNetCore.Authorization;
using EZero.Application.Dto.Request.Auth;

namespace EZero.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUserAppService _userAppService;

        public HomeController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public IActionResult Index(LoginRequest request)
        {
            var loginRequest = new LoginRequest();
            var id = _userAppService.GetUserInfo(1);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
