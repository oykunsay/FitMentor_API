using Microsoft.AspNetCore.Mvc;

namespace FitMentor_UI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
