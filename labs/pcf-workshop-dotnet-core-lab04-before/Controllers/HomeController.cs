﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Pcf.Workshop.Dotnet.Core.Lab04.Before.Models;

namespace Pcf.Workshop.Dotnet.Core.Lab04.Before.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
