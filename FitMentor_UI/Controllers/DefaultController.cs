﻿using Microsoft.AspNetCore.Mvc;

namespace FitMentor_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
