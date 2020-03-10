using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Action.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
       // {
         //   return View();
       // }
        public RedirectToRouteResult RedirectAction()
        {
            return RedirectToAction("Index", "Admin", new { id = "MyIdValue" });
        }
        public ContentResult getContext()
        {
            return Content("Sample Text", "text");
        }
        public JavaScriptResult getScript()
        {
            return JavaScript(@"function getmsg(){alert('Script alert from MVC')}");
        }
        public HttpUnauthorizedResult AuthPage(string id)
        {
            return new HttpUnauthorizedResult("You are not authorized to view this content");
        }
    }
}