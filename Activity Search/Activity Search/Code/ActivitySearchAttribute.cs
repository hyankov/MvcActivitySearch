using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity_Search.Code
{
    public class ActivitySearchAttribute : ActionFilterAttribute
    {
        public string Text { get; set;}
        public string ImageUrl { get; set; }

        public ActivitySearchAttribute(string text) : this(text, null)
        {
        }

        public ActivitySearchAttribute(string text, string imageUrl)
        {
            Text = text;
            ImageUrl = imageUrl;
        }
    }
}
