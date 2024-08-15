using Microsoft.AspNetCore.Mvc;

namespace FitMentor_UI.ViewComponents.Layout
{
    public class _HeadarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
