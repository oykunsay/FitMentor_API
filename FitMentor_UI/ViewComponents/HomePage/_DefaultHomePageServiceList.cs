using Microsoft.AspNetCore.Mvc;

namespace FitMentor_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageServiceList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
