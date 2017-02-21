using System.Web.Mvc;

namespace ActivitySearch.Code
{
    public class ActivitySearchAttribute : ActionFilterAttribute
    {
        public ActivitySearchAttribute(string text) : this(text, null)
        {
        }

        public ActivitySearchAttribute(string text, string imageUrl)
        {
            Text = text;
            ImageUrl = imageUrl;
        }

        public string ImageUrl { get; set; }
        public string Text { get; set; }
    }
}