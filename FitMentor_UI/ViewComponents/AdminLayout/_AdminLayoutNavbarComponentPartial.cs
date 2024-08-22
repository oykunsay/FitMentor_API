using Microsoft.AspNetCore.Mvc;

namespace FitMentor_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}