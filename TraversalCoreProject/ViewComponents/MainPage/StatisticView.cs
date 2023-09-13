using DataAccessLayer.Consrate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.MainPage
{
    public class StatisticView: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.d = c.Destinations.Count();
            ViewBag.g= c.Guides.Count();

            return View();
        }
    }
}
