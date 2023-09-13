
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MainPage
{
    public class SliderView:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
