using Microsoft.AspNetCore.Mvc;

namespace FitMentor_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}