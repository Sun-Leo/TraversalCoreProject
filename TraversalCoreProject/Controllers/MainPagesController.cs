using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class MainPagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
