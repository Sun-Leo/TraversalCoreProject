using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        public IActionResult Index()
        {
            var item = destinationManager.TGetList();
            return View(item);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var item = destinationManager.TGetById(id);
            return View(item);
        }
        [HttpPost]
        public IActionResult Details(Destination ds)
        {
            return View();
        }
    }
}
