using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity_Search.Code;

namespace Activity_Search.Controllers
{
    public class AnotherController : Controller
    {
        // GET: /Another/
        [ActivitySearch("Another Controller index page")]
        public ActionResult Index()
        {
            return View("Common");
        }

        // GET: /Another/Something
        [ActivitySearch("Method Something", "group.png")]
        public ActionResult Something()
        {
            return View("Common");
        }
    }
}
