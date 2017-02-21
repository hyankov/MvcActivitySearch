using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity_Search.Code;

namespace Activity_Search.Controllers
{
    public class SomeController : Controller
    {
        // GET: /Some/
        [ActivitySearch("Some Controller index page")]
        public ActionResult Index()
        {
            return View("Common");
        }

        // GET: /Some/Method
        [ActivitySearch("Some Method", "group.png")]
        public ActionResult Method()
        {
            return View("Common");
        }
    }
}
