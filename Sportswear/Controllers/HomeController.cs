﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Sportswear.Models;
using System.Diagnostics;

namespace Sportswear.Controllers
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
<<<<<<< HEAD
=======
            return View();
>>>>>>> testingbranch
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult aboutUs()
        {
            return View();
        }

        public IActionResult viewProduct()
        {
            return new RedirectResult(Url.Action("Index") + "#view-product");
        }

        public IActionResult viewCart()
        {
            return View("~/Views/Cart/ViewCart.cshtml");
        }
        
        public IActionResult AdminPanel()
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
