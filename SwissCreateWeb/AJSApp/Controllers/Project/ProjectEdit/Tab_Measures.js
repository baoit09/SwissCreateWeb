jQuery(document).ready(function ($) {

    $("#divCheckBoxes_Measures :checkbox").change(checkboxFilterOnChange);

    //$('.date-picker').datepicker(
    //{
    //    //dateFormat : 'dd/mm/yy'
    //});
    
    setupJsGrids();

});

function checkboxFilterOnChange(e) {
    $("#jsGrid_Measures").jsGrid("loadData");
}

function getCheckedValues(parentDiv) {
    var checkedValues = [];
    $("#" + parentDiv + " :checked").each(function (index, element) {
        checkedValues.push($(element).val());
    })
    return checkedValues;
}

function setupJsGrids()
{
    $("#jsGrid_Measures").jsGrid({
        height: "100%",
        width: "100%",
        //filtering: true,
        //editing: true,
        sorting: true,
        paging: true,
        autoload: true,

        pageSize: 15,
        pageButtonCount: 5,

        deleteConfirm: "Do you really want to delete?",

        rowClick: function (args) {
            showDetailsDialog("Edit", args.item);
        },

        controller: {
            loadData: function (filter) {

                var stepIndex = window.db.projectSettings.Step_Measures_Index;
                var measurements = window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].Measurement.Measurements;

                var checkedValues = getCheckedValues('divCheckBoxes_Measures');
                var filterMeasurements = [];

                $(measurements).each(function(i, e)
                {
                    if ($.inArray(e.Status, checkedValues) > -1) {

                        var date = new Date(parseInt(e.StartedDate.substr(6)));
                        e.StartedDateString = date.getDate() + "/" + (date.getMonth() + 1) + "/" + date.getFullYear();
                        e.DurationString = e.Duration + " day(s)";
                        e.DaysRemainingString = e.DaysRemaining + " day(s)";

                        filterMeasurements.push(e);
                    }
                });

                return filterMeasurements;
            }
        },

        fields: [
            { name: "Name", type: "text", title: "Title", width: 100 },
            { name: "StartedDateString", type: "text", width: 100, title: "Start" },

            { name: "DurationString", type: "text", title: "Duration", width: 100 },
            { name: "Status", type: "text", title: "Status", width: 150 },

            { name: "ResponsiblePerson", type: "text", title: "Responsible Person", width: 100 },
            { name: "Department", type: "text", title: "Department", width: 100 },

            { name: "DaysRemainingString", type: "text", title: "Remain", width: 100 }

            //{ type: "control" }
        ]
    });
}

var showDetailsDialog = function (dialogType, item) {

    $("#detailsForm").modal("show");

    $("#modelTitle").html("Measurement");

    $("#Name").val(item.Name);
  
    $("#Goal").val(item.Goal);

    $("#Procedure").val(item.Procedure);

    $("#Expenses").val(item.Expenses);

    $("#ExpectedBenefits").val(item.ExpectedBenefits);

    $("#ResponsiblePerson").val(item.ResponsiblePerson);

    $("#Department").val(item.Department);

    $("#button_OK").off("click").on("click", function () {
        saveClient(item, dialogType === "Add");
    });
};

var saveClient = function (item, isNew) {

    $.extend(item, {
        Name: $("#Name").val(),
        Goal: $("#Goal").val(),
        Procedure: $("#Procedure").val(),
        Expenses: $("#Expenses").val(),
        ExpectedBenefits: $("#ExpectedBenefits").val(),
        ResponsiblePerson: $("#ResponsiblePerson").val(),
        Department: $("#Department").val()
    });

    $("#jsGrid_Measures").jsGrid(isNew ? "insertItem" : "updateItem", item);

    $("#detailsForm").modal("hide");
};

function doSave()
{
    var postUrl = $("#Hidden_Post_Measures").val();

    var measurements = window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].Measurement.Measurements;

    var JSONDataString = JSON.stringify({
        projectId: $("#Hidden_ProjectId").val(),
        //stepIndex: $("#Hidden_StepIndex").val(),
        measurements: measurements
    });

    $.ajax({

        url: postUrl,

        type: "POST",

        contentType: "application/json",

        data: JSONDataString,

        success: function (ResponseResult) {
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



