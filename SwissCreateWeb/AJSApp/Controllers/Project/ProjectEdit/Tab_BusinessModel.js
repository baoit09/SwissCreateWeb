jQuery(document).ready(function ($) {        
});

function doSave()
{
    var form_QA = $("#form_QA")

    // Post data to server
    var url = form_QA.attr("action");
    $.post(url,
            "projectId=" + $("#Hidden_ProjectId").val() + 
            "&stepIndex=" + $("#Hidden_StepIndex").val() +
            "&" + form_QA.serialize(),
        
        function (ResponseResult) {
            if (ResponseResult.success == true) {
                bootbox.alert("Project saved successfully!", function () {                   
                });
            }
            else {
                bootbox.dialog({
                    message: "Project saved failed",
                    title: "Project saved",
                    buttons: {
                        danger: {
                            label: "OK",
                            className: "btn-danger"
                        }
                    }
                });
            }
        });
}



