using Microsoft.AspNetCore.Mvc;
namespace FitMentor_UI.ViewComponents.AdminLayout

{
    public class _AdminLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
