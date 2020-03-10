using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResult.Controllers
{
    public class AdminController : Controller
    {
        private string id;

        // GET: Admin
        public string Index()
        {
            return "You entered " + id;
        }
    }
}