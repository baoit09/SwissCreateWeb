jQuery(document).ready(function ($) {

    $('#tabs').tab();

    $('#tabs a').click(function (e) {

        e.preventDefault();
       
        var tabID = $(this).attr("href").substr(1);
        $(".tab-pane").each(function () {
            $(this).empty();
        });

        var url = $("#GetTab").val() + "/" + tabID + "?projectId=" + $("#ProjectEdittingId").val();
        var request = $.ajax({
            //url: '/@ViewContext.RouteData.Values["controller"]/' + tabID +"?projectId=" + 23,
            url: url,
            cache: false,
            type: "get",
            dataType: "html"            
        });

        request.done(function (msg) {
            $("#" + tabID).html(msg);
        });

        request.fail(function (jqXHR, textStatus) {
            alert("Request failed: " + textStatus);
        });

        $(this).tab('show')

    });
    
});

