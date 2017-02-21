using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivitySearch.Code;

namespace ActivitySearch.Controllers
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
