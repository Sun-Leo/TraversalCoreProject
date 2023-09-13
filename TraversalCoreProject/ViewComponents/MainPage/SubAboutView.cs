using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MainPage
{
    public class SubAboutView: ViewComponent
    {
        SubAboutManager aboutManager = new SubAboutManager(new EFSubAboutDal());

        public IViewComponentResult Invoke()
        {
            var item = aboutManager.TGetList();
            return View(item);
        }
    }
}
