using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ActivitySearch.Code;

namespace ActivitySearch.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [ActivitySearch("Home Sweet Home")]
        public ActionResult Index()
        {
            return View("Common");
        }
    }
}
