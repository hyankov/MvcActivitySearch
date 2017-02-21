var text = "Type what you need to do...";
var feedUrl = "/Search/Activities";

$(document).ready(function() {
    var searchObj = $("#search");

    // Set initial value
    searchObj.val(text);

    // For when we start input
    searchObj.focus(function() {
        $(this).val("");
    });

    // For when we blur the field
    searchObj.blur(function() {
        $(this).val(text);
    });

    searchObj.autocomplete(feedUrl, {
        dataType: "json",
        parse: function(data) {
            return $.map(data, function(row) {
                return {
                    data: row,
                    value: row.Url,
                    result: row.Text
                }
            });
        },
        formatItem: function(item) {
        if (item != null) {
                if (item.Image != null && item.Image != "")
                    return "<img src='/Content/images/" + item.Image 
                    + "' alt='" + item.Text + "' /> " + item.Text;
                else
                    return item.Text;
            }
            else
                return null;
        }
    }).result(function(event, item) {
        if (item != null && item.Url != null) {
            searchObj.trigger('blur');
            location.href = item.Url;
        }
    });
});