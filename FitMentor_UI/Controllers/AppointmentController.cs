using Microsoft.AspNetCore.Mvc;

namespace FitMentor_UI.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
