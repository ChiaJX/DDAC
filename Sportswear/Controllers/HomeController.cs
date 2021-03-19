﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;
using Sportswear.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sportswear.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //string StorageName = "Enter your storage name";
        //string StorageKey = "Enter the storage key";
        //string TableName = "CraneMachineMaterialUsage()";
        string AccessKey = "WACOy6+vQaT1XXsPzIK3oe1cl0EWcv3C3J4wJU82nW12V6HxlbSKoFx4QRqG1nRzBIhKXikEtkEve8bVwf4F2A==";
        string StorageName = "sportsweartp050653";
        string TableName = "ProductTable";


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string jsonData;
            AzureTables.GetAllEntity(StorageName, AccessKey, TableName, out jsonData);
            ProductEntity productEntity = JsonConvert.DeserializeObject<ProductEntity>(jsonData);
            return View(productEntity);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult aboutUs()
        {
            return View();
        }

        public IActionResult productDetails(string productName)
        {
            ViewBag.message = "====>"+ productName + "<========";
            return View();
        }

        public IActionResult viewCart()
        {
            return View("~/Views/Cart/ViewCart.cshtml");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
