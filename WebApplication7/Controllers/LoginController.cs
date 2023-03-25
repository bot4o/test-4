﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication7.Data;

namespace WebApplication7.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
