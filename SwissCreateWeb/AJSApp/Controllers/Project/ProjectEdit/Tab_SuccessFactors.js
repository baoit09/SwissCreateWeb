$(document).ready(function() {
    $.ajax({
        url: $("#Hidden_Get_Step_TaskItemStep").val(),
        type: 'POST',
        data: { "projectId": $("#Hidden_ProjectId").val() },
        success: function (data) {
            window.db.TaskItemStep = $.parseJSON(data);
            SetupJsGrids();            
        },
        error: function (jqXHR, textStatus, errorThrown) {
            //...
        }
    });
});


function SetupJsGrids()
{
    $("#jsGrid_HumanCaptial").jsGrid({
        height: "100%",
        width: "100%",
        //filtering: true,
        editing: true,
        sorting: true,
        paging: true,
        autoload: true,

        pageSize: 15,
        pageButtonCount: 5,

        deleteConfirm: "Do you really want to delete?",

        controller: {
            loadData: function (filter) {
                return window.db.TaskItemStep.TaskItemGroups[0].Tasks;               
            }
        },

        fields: [
            { name: "ID", type: "text", width: 100 },
            { name: "Name", type: "text", width: 150 },
            { name: "Active", type: "checkbox", width: 50, title: "Active", sorting: false },
            { name: "Define", type: "text", width: 500 },
            { type: "control" }
        ]        
    });

    //$("#jsGrid_StructuralCapital").css("min-height", "500px");
    //$("#jsGrid_StructuralCapital").css("padding", "1px");
    
    $("#jsGrid_StructuralCapital").jsGrid({
        height: "500px",
        width: "100%",
        //filtering: true,
        editing: true,
        sorting: true,
        paging: true,
        autoload: true,

        pageSize: 15,
        pageButtonCount: 5,

        deleteConfirm: "Do you really want to delete?",

        controller: {
            loadData: function (filter) {
                return window.db.TaskItemStep.TaskItemGroups[1].Tasks;
            }
        },

        fields: [
            { name: "ID", type: "text", width: 100 },
            { name: "Name", type: "text", width: 150 },
            { name: "Active", type: "checkbox", width: 50, title: "Active", sorting: false },
            { name: "Define", type: "text", width: 500 },
            { type: "control" }
        ]
    });

    
    $("#jsGrid_RelationshipCapital").jsGrid({
        height: "500px",
        width: "100%",
        //filtering: true,
        editing: true,
        sorting: true,
        paging: true,
        autoload: true,

        pageSize: 15,
        pageButtonCount: 5,

        deleteConfirm: "Do you really want to delete?",

        controller: {
            loadData: function (filter) {
                return window.db.TaskItemStep.TaskItemGroups[2].Tasks;
            }
        },

        fields: [
            { name: "ID", type: "text", width: 100 },
            { name: "Name", type: "text", width: 150 },
            { name: "Active", type: "checkbox", width: 50, title: "Active", sorting: false },
            { name: "Define", type: "text", width: 500 },
            { type: "control" }
        ]
    });

    $("#jsGrid_Weight").jsGrid({
        height: "500px",
        width: "100%",
        //filtering: true,
        //editing: true,
        sorting: true,
        paging: true,
        autoload: true,

        pageSize: 15,
        pageButtonCount: 5,

        deleteConfirm: "Do you really want to delete?",

        controller: {
            loadData: function (filter) {
                var mergedTasks = [];
                mergedTasks = $.merge(mergedTasks, window.db.TaskItemStep.TaskItemGroups[0].Tasks);
                mergedTasks = $.merge(mergedTasks, window.db.TaskItemStep.TaskItemGroups[1].Tasks);
                mergedTasks = $.merge(mergedTasks, window.db.TaskItemStep.TaskItemGroups[2].Tasks);                
                return mergedTasks;
            }
        },

        fields: [
            { name: "ID", type: "text", width: 100 },
            { name: "Name", type: "text", width: 150 },
            { name: "Active", type: "checkbox", width: 50, title: "Active", sorting: false },
            { name: "Define", type: "text", width: 500 }            
        ]
    });
}

function doSave()
{
    var postUrl = $("#Hidden_Post_Step_TaskItemStep").val();

    var JSONDataString = JSON.stringify({
        projectId: $("#Hidden_ProjectId").val(),
        //stepIndex: $("#Hidden_StepIndex").val(),
        tasks0: window.db.TaskItemStep.TaskItemGroups[0].Tasks,
        tasks1: window.db.TaskItemStep.TaskItemGroups[1].Tasks,
        tasks2: window.db.TaskItemStep.TaskItemGroups[2].Tasks,
    });

    $.ajax({

        url: postUrl,

        type: "POST",

        contentType: "application/json",

        data: JSONDataString,

        success: function (ResponseResult)
        {
            if (ResponseResult.success == true) {

                var form_StepResult = $("#form_StepResult")

                // Post data to server
                var url = form_StepResult.attr("action");
                $.post(url,
                        "projectId=" + $("#Hidden_ProjectId").val() +
                        "&stepIndex=" + $("#Hidden_StepIndex").val() +
                        "&" + form_StepResult.serialize(),

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
        }
    });
}



