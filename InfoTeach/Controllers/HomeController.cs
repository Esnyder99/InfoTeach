﻿using InfoTeach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTeach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LessonsContext _ctx;

        public HomeController(ILogger<HomeController> logger, LessonsContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InfoTeachContactUs()
        {
            return View();
        }
        public IActionResult InfoTeachSiteUpdates()
        {
            return View();
        }
        public IActionResult InfoTeachContribute()
        {
            return View();
        }
        public IActionResult InfoTeachAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
