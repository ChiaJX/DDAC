﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Sportswear.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Sportswear.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICosmosDbService _cosmosDbService;

        public HomeController(ICosmosDbService cosmosDbService, ILogger<HomeController> logger)
        {
            _cosmosDbService = cosmosDbService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _cosmosDbService.GetItemsAsync("SELECT * FROM c"));
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
            return View();
        }
        
        public IActionResult AdminPanel()
        {
            return View();
        }

        public IActionResult FAQ()
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
