using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActivitySearch.Code
{
    public class ActivitySearchResultItem
    {
        public string Text;
        public string Url;
        public string Image;

        public ActivitySearchResultItem(string text, string url, string imageUrl)
        {
            Text = text;
            Url = url;
            Image = imageUrl;
        }
    }
}
