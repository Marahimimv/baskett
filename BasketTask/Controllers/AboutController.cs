﻿using Microsoft.AspNetCore.Mvc;

namespace BasketTask.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
