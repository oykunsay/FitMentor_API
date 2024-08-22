using Microsoft.AspNetCore.Mvc;

namespace FitMentor_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
