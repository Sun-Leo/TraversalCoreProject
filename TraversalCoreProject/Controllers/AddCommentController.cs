using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class AddCommentController : Controller
    {
        public PartialViewResult CommentAdd()
        {
            return PartialView();
        }

       
    }
}
