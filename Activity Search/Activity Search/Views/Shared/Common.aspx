<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Common Page</title>
    
    <link href="/Content/jquery.autocomplete.css" rel="stylesheet" type="text/css" />
    
    <script type="text/javascript" src="<%= Url.Content("~/Scripts/jquery-1.3.2.min.js") %>"></script>
    <script type="text/javascript" src="<%= Url.Content("~/Scripts/lib/jquery.ajaxQueue.js") %>"></script>
    <script type="text/javascript" src="<%= Url.Content("~/Scripts/jquery.autocomplete.pack.js") %>"></script>
    <script type="text/javascript" src="<%= Url.Content("~/Scripts/activitySearch.js") %>"></script>
</head>
<body>
    <div>
        Example: "some"; "method"
    </div>
    <div>
        <input id="search" name="search" type="text" value="" style="width: 250px" />
    </div>
</body>
</html>
