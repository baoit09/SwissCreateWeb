$(document).ready(function () {
    var db = {};
    $.ajax({
        url: $("#Hidden_Get_Step_TaskItemStep").val(),
        type: 'POST',
        data: { "projectId": $("#Hidden_ProjectId").val() },
        success: function (data) {
            db.TaskItemStep = $.parseJSON(data);

            window.db = db;
            SetupJsGrids();
        },
        error: function (jqXHR, textStatus, errorThrown) {
            //...
        }
    });
});
   
$(".inputCanChange").bind('input', function () {
    var value = $(this).val();
    var urlImage = getURLImage(value);
    var idImageTarget = $(this).data("targetimage");
    $("#" + idImageTarget).attr('src', urlImage);
});

function SetupJsGrids() {

    var MyImgField = function (config) {
        jsGrid.Field.call(this, config);
    };

    MyImgField.prototype = new jsGrid.Field({

        //css: "date-field",            // redefine general property 'css'
        align: "center",              // redefine general property 'align'

        //myCustomProperty: "foo",      // custom property

        //sorter: function (date1, date2) {
        //    return new Date(date1) - new Date(date2);
        //},

        itemTemplate: function (value) {
            return "<img src=" + getURLImage(value) + " alt='test' height='25' width='25'/>";
        },

        //insertTemplate: function (value) {
        //    return this._insertPicker = $("<input>").datepicker({ defaultDate: new Date() });
        //},

        //editTemplate: function (value) {
        //    return this._editPicker = $("<input>").datepicker().datepicker("setDate", new Date(value));
        //},

        //insertValue: function () {
        //    return this._insertPicker.datepicker("getDate").toISOString();
        //},

        //editValue: function () {
        //    return this._editPicker.datepicker("getDate").toISOString();
        //}
    });

    jsGrid.fields.img = MyImgField;

    $("#jsGrid_Review").jsGrid({
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

        rowClick: function(args)
        {
            showDetailsDialog("Edit", args.item);
        },

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
            { name: "ID", type: "text", width: 50 },
            { name: "Name", type: "text", width: 200 },
            { name: "Active", type: "checkbox", width: 50, title: "Active", sorting: false },

            { name: "Quality_WeightPercent", type: "text", title: "Quality", width: 50 },
            { name: "Quality_WeightPercent", type: "img", title: " ", width: 30 },

            { name: "Quantity_WeightPercent", type: "text", title: "Quantity", width: 50 },
            { name: "Quantity_WeightPercent", type: "img", title: " ", width:30 },

            { name: "Systematic_WeightPercent", type: "text", title: "Systematic", width: 50 },
            { name: "Systematic_WeightPercent", type: "img", title: " ", width: 30 },
            
            //{ type: "control" }
        ]
    });    
}

var showDetailsDialog = function (dialogType, item) {

    $("#detailsForm").modal("show");

    $("#modelTitle").html("Detail of " + item.ID + ":");
    
    // Tiêu đề
    $("#Name").val(item.Name);
    // Định nghĩa
    $("#Define").val(item.Define);

    // So luong
    $("#Quality_Question").val(item.Quality_Question);
    $("#Quality_WeightPercent").val(item.Quality_WeightPercent);
    $("#Quality_Answer").val(item.Quality_Answer);
    
    // Chat luong
    $("#Quantity_Question").val(item.Quantity_Question);
    $("#Quantity_WeightPercent").val(item.Quantity_WeightPercent);
    $("#Quantity_Answer").val(item.Quantity_Answer);
    
    // He thong
    $("#Systematic_Question").val(item.Systematic_Question);
    $("#Systematic_WeightPercent").val(item.Systematic_WeightPercent);
    $("#Systematic_Answer").val(item.Systematic_Answer);

    $("#button_OK").off("click").on("click", function () {
        saveClient(item, dialogType === "Add");
    });

    updateImage();
};

var saveClient = function (item, isNew) {
   
    $.extend(item, {
    // Tiêu đề
    Name:    $("#Name").val(),
    // Định nghĩa
    Define: $("#Define").val(),

    // So luong
    Quality_Question: $("#Quality_Question").val(),
    Quality_WeightPercent: $("#Quality_WeightPercent").val(),
    Quality_Answer: $("#Quality_Answer").val(),
    
    // Chat luong
    Quantity_Question: $("#Quantity_Question").val(),
    Quantity_WeightPercent: $("#Quantity_WeightPercent").val(),
    Quantity_Answer: $("#Quantity_Answer").val(),
    
    // He thong
    Systematic_Question: $("#Systematic_Question").val(),
    Systematic_WeightPercent: $("#Systematic_WeightPercent").val(),
    Systematic_Answer: $("#Systematic_Answer").val()
    });

    $("#jsGrid_Review").jsGrid(isNew ? "insertItem" : "updateItem", item);

    $("#detailsForm").modal("hide");
};

function getURLImage(value)
{
    var urlImageSrc = window.projectSettings.Url_Image_Happy;

    if (value <= window.projectSettings.Quantity_Image_Level3)
        urlImageSrc = window.projectSettings.Url_Image_Happy;
    if (value <= window.projectSettings.Quantity_Image_Level2)
        urlImageSrc = window.projectSettings.Url_Image_Normal;
    if (value <= window.projectSettings.Quantity_Image_Level1)
        urlImageSrc = window.projectSettings.Url_Image_Sad;

    return urlImageSrc;
}

function updateImage()
{
    $(".inputCanChange").each(function (i, e) {
        var value = $(e).val();
        var urlImage = getURLImage(value);
        var idImageTarget = $(e).data("targetimage");
        $("#" + idImageTarget).attr('src', urlImage);
    });
}

function doSave() {

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



