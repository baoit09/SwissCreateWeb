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
});

function setupCharts() {
    //mergeTasks();
    drawCharts();
    //google.setOnLoadCallback(drawCharts);
}

function mergeTasks() {
    var mergedTasks = [];
    mergedTasks = $.merge(mergedTasks, window.db.TaskItemStep.TaskItemGroups[2].Tasks);
    mergedTasks = $.merge(mergedTasks, window.db.TaskItemStep.TaskItemGroups[1].Tasks);
    mergedTasks = $.merge(mergedTasks, window.db.TaskItemStep.TaskItemGroups[0].Tasks);
    window.db.mergedTasks = mergedTasks;
}

function drawCharts() {

    var data = new google.visualization.DataTable();

    data.addColumn('string', 'Name');
    data.addColumn('number', 'Weight');
    data.addColumn({ type: 'string', role: 'style' });
    data.addColumn({ type: 'string', role: 'annotation' });

    for (var i = 0; i < window.db.TaskItemStep.TaskItemGroups[2].Tasks.length; i++) {
        data.addRow([window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].ID + ": " + window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].Name, window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].Weight, "color: red", window.db.TaskItemStep.TaskItemGroups[2].Tasks[i].Weight.toString()]);
    }

    for (var i = 0; i < window.db.TaskItemStep.TaskItemGroups[1].Tasks.length; i++) {
        data.addRow([window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].ID + ": " + window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].Name, window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].Weight, "color: blue", window.db.TaskItemStep.TaskItemGroups[1].Tasks[i].Weight.toString()]);
    }

    for (var i = 0; i < window.db.TaskItemStep.TaskItemGroups[0].Tasks.length; i++) {
        data.addRow([window.db.TaskItemStep.TaskItemGroups[0].Tasks[i].ID + ": " + window.db.TaskItemStep.TaskItemGroups[0].Tasks[i].Name, window.db.TaskItemStep.TaskItemGroups[0].Tasks[i].Weight, "color: green", window.db.TaskItemStep.TaskItemGroups[0].Tasks[i].Weight.toString()]);
    }

    var options = {
        title: "Weight Bar Chart",
        bar: {
            groupWidth: "90%"
        },
        legend: { position: "none" },
    };

    var chart = new google.visualization.BarChart(document.getElementById('div_WeightBarChart'));
    chart.draw(data, options);
}

function doSave() {

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



