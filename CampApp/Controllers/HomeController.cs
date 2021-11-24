﻿using CampApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CampApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rental()
        {
            return View();
        }

        public IActionResult Subscription()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Subscription(SubscriptionModel model)
        {
            if (model != null)
            {
                ViewBag.name = model.name;
            }
            else
            {
                ViewBag.name = "No Name";
            }
            return View(model);
        }

        public IActionResult SubscCheck()
        {
            return View();
        }


        public IActionResult E_Commerce()
        {
            return View();
        }

        public IActionResult Inquiry()
        {
            return View();
        }

        public IActionResult LogIn()
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
