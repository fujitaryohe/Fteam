using CampApp.Models;
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

        public IActionResult SubscCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubscCheck(SubscriptionModel model)
        {
            if (model != null)
            {
                ViewBag.name = model.name;
                ViewBag.furigana = model.furigana;
                ViewBag.gender = model.gender;
                ViewBag.birthday = model.birthday;
                ViewBag.ID = model.ID;
                ViewBag.password = model.password;
                ViewBag.rePassword = model.rePassword;
                ViewBag.address = model.address;
                ViewBag.phonenum = model.phonenum;
                ViewBag.mail = model.mail;
            }
            else
            {
                ViewBag.name = "No Name";
            }
            return View(model);
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
