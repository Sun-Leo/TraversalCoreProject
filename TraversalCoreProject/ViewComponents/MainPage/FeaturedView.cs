using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MainPage
{
    public class FeaturedView: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
