using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using System.Reflection;
using Activity_Search.Code;

namespace Activity_Search.Controllers
{
    public class SearchController : Controller
    {
        // GET: /Search/Activities
        public JsonResult Activities(string q, int limit)
        {
            Regex regex = new Regex(@"(" + q + ")", RegexOptions.IgnoreCase);
            IList<ActivitySearchResultItem> results = new List<ActivitySearchResultItem>();

            // Find all controllers
            IList<Type> controllers = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(Controller))).ToList();
            foreach (Type controller in controllers)
            {
                if (results.Count == limit)
                    break;

                // Get all public non-static methods of the controller
                var methods = controller.GetMethods(BindingFlags.Public | BindingFlags.Instance);
                foreach (var method in methods)
                {
                    if (results.Count == limit)
                        break;

                    if (method.ReturnType == typeof(ActionResult))
                    {
                        // We don't want to show POST methods
                        var httpPostAttribute = method.GetCustomAttributes(typeof(HttpPostAttribute), true)
                                            .Cast<HttpPostAttribute>()
                                            .FirstOrDefault();

                        // Find the DisplayName attribute
                        var attribute = method.GetCustomAttributes(typeof(ActivitySearchAttribute), true)
                                            .Cast<ActivitySearchAttribute>()
                                            .FirstOrDefault();

                        // Return those results, which:
                        // Are GET method
                        // Have 'DisplayName'
                        // And 'DisplayName' of the action, matches the search criteria
                        if (httpPostAttribute == null && attribute != null && regex.IsMatch(attribute.Text))
                        {
                            results.Add(new ActivitySearchResultItem(attribute.Text, Url.Action(method.Name, controller.Name.Replace("Controller", "")), attribute.ImageUrl));
                        }
                    }
                }
            }

            // Return the results in a JSON form
            return Json(results, JsonRequestBehavior.AllowGet);
        }
    }
}
