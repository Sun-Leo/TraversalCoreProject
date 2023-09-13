using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.DetailsPage
{
    public class CommentView: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
