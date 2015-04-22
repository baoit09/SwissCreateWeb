//google.load('visualization', '1', { packages: ['corechart', 'bar'] });

jQuery(document).ready(function ($) {

    var db = {};
    $.ajax({
        url: $("#Hidden_Get_Step_TaskItemStep").val(),
        type: 'POST',
        data: { "projectId": $("#Hidden_ProjectId").val() },
        success: function (data) {
            db.TaskItemStep = $.parseJSON(data);
            window.db = db;
            setupCharts();
        },
        error: function (jqXHR, textStatus, errorThrown) {
            //...
        }
    });

    $(".radioFilter").change(radioFilterOnChange);
    $("#radio_HC").attr("checked", "checked");

    $(".checkboxFilter").change(checkboxFilterOnChange);
    
    
});

function radioFilterOnChange(e) {
    var newSelectedCode = $(this).val();
    if (newSelectedCode != window.selectCode) {
        window.selectCode = $(this).val();
        drawCharts_Valuation();
    }
}

function checkboxFilterOnChange(e) {
    drawCharts_Weight();
}

function setupCharts() {
    drawCharts();
}

function mergeTasks() {
    var mergedTasks = [];
    mergedTasks = $.merge(mergedTasks, window.db.TaskItemStep.TaskItemGroups[2].Tasks);
    mergedTasks = $.merge(mergedTasks, window.db.TaskItemStep.TaskItemGroups[1].Tasks);
    mergedTasks = $.merge(mergedTasks, window.db.TaskItemStep.TaskItemGroups[0].Tasks);
    window.db.mergedTasks = mergedTasks;
}

function drawCharts() {
    drawCharts_Weight();
    drawCharts_Valuation();
}


function drawCharts_Weight() {

    var data = new google.visualization.DataTable();

    data.addColumn('string', 'Name');
    data.addColumn('number', 'Weight');
    data.addColumn({ type: 'string', role: 'style' });
    data.addColumn({ type: 'string', role: 'annotation' });

    for (var i = 0; i < window.db.TaskItemStep.TaskItemGroups[0].Tasks.length; i++) {
        data.addRow([window.db.TaskItemStep.TaskItemGroups[0].Tasks[i].ID + ": " + window.db.TaskItemStep.TaskItemGroups[0].Tasks[i].Name, window.db.TaskItemStep.TaskItemGroups[0].Tasks[i].Weight, "color: green", window.db.TaskItemStep.TaskItemGroups[0].Tasks[i].Weight.toString()]);
    }

    for (var i = 0; i < window.db.TaskItemStep.TaskItemGroups[1].Tasks.length; i++) {
        data.addRow([window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].ID + ": " + window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].Name, window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].Weight, "color: blue", window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].Weight.toString()]);
    }

    for (var i = 0; i < window.db.TaskItemStep.TaskItemGroups[2].Tasks.length; i++) {
        data.addRow([window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].ID + ": " + window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].Name, window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].Weight, "color: red", window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].Weight.toString()]);
    }

    var options = {
        width: 900,
        height: 500,
        title: "Weight Bar Chart",
        bar: {
            groupWidth: "90%"
        },
        legend: { position: "none" },
    };

    var chart = new google.visualization.BarChart(document.getElementById('div_WeightBarChart'));
    chart.draw(data, options);
}

function drawCharts_Valuation() {

    var data = new google.visualization.DataTable();

    data.addColumn('string', 'Name');
    data.addColumn('number', 'Quantity');
    data.addColumn('number', 'Quality');
    data.addColumn('number', 'Systematic');

    //data.addColumn({ type: 'string', role: 'style' });
    //data.addColumn({ type: 'string', role: 'annotation' });

    //for (var i = 0; i < window.db.TaskItemStep.TaskItemGroups[2].Tasks.length; i++) {
    //    data.addRow([window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].ID + ": " + window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].Name,
    //        window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].Quantity_WeightPercent, window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].Quality_WeightPercent, window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].Systematic_WeightPercent]);
    //}

    //for (var i = 0; i < window.db.TaskItemStep.TaskItemGroups[1].Tasks.length; i++) {
    //    data.addRow([window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].ID + ": " + window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].Name,
    //        window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].Quantity_WeightPercent, window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].Quality_WeightPercent, window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].Systematic_WeightPercent]);
    //}

    

    var taskItemIndex = 0;
    if (window.selectCode === "HC") {
        taskItemIndex = 0;
    }
    else if (window.selectCode === "SC") {
        taskItemIndex = 1;
    }
    else if (window.selectCode === "RC") {
        taskItemIndex = 2;
    }

    for (var i = 0; i < window.db.TaskItemStep.TaskItemGroups[taskItemIndex].Tasks.length; i++) {
        data.addRow([window.db.TaskItemStep.TaskItemGroups[taskItemIndex].Tasks[i].ID + ": " + window.db.TaskItemStep.TaskItemGroups[taskItemIndex].Tasks[i].Name,
            window.db.TaskItemStep.TaskItemGroups[taskItemIndex].Tasks[i].Quantity_WeightPercent,
            window.db.TaskItemStep.TaskItemGroups[taskItemIndex].Tasks[i].Quality_WeightPercent,
            window.db.TaskItemStep.TaskItemGroups[taskItemIndex].Tasks[i].Systematic_WeightPercent]);
    }
    
    var options = {
        width: 900,
        height: 500,
        title: "Valuation Bar Chart",
        bars: 'horizontal', // Required for Material Bar Charts.
        bar: {
            groupWidth: "90%"
        },
        legend: { position: "none" },
    };

    var chart = new google.charts.Bar(document.getElementById('div_ValuationBarChart'));
    chart.draw(data, options);
}

function doSave() {

    // Post data to server
    var url = $("#Hidden_Save_Tab_Evaluation").val();
    $.post(url,

            "projectId=" + $("#Hidden_ProjectId").val() +
            "&sInterpretation1=" + $("#textarea_Interpretation1").val() +
            "&sInterpretation2=" + $("#textarea_Interpretation2").val() +
            "&sInterpretation3=" + $("#textarea_Interpretation3").val(),

        function (ResponseResult) {
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
        });
}



