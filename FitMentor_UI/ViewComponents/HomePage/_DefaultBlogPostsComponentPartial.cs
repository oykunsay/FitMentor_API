﻿using Microsoft.AspNetCore.Mvc;

namespace FitMentor_UI.ViewComponents.HomePage
{
    public class _DefaultBlogPostsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
