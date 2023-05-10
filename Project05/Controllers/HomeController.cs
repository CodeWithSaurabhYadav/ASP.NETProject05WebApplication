﻿using Microsoft.AspNetCore.Mvc;
using Project05.Models;
using System.Diagnostics;

namespace Project05.Controllers
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
        [HttpPost]
        public IActionResult Search()
        {
            string searchString = Request.Form["search"];
            TempData["EmployeeID"] = searchString;
            return RedirectToAction("Index","Search");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}