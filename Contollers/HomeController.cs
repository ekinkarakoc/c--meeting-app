﻿using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
