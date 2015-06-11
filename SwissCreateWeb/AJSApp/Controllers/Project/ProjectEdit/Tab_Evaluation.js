jQuery(document).ready(function ($) {

    $('#a_evaluation').on('shown.bs.tab', function (e)
    {
        if (window.db === undefined || window.db.tabEvaluation === undefined || window.db.tabEvaluation.tabLoaded === false)
        {
            initData_TabEvaluation();

            initEventHanlders_TabEvaluation();            

            setupCharts();

            window.db.tabEvaluation.tabLoaded = true;
        }
    });    
});

function initData_TabEvaluation()
{
    if (window.db === undefined)
    {
        window.db = {};
    }

    if (window.db.tabEvaluation === undefined)
    {
        window.db.tabEvaluation = {};
        window.db.tabEvaluation.tabLoaded = false;

        var tabIndex = window.db.projectSettings.Step_SuccessFactors_Index;
        window.db.tabEvaluation.taskItemStep = window.db.projectEditing.ProjectData.Periods[0].Steps[tabIndex].TaskItemStep;
    }
}

function initEventHanlders_TabEvaluation()
{
    $(".radioFilter_Valuation").change(radioFilterOnChange_Valuation);
    $("#radio_HC").attr("checked", "checked");

    $("#divCheckBoxes_Weight :checkbox").change(checkboxFilterOnChange_Weight);
    $("#checkbox_HC").attr("checked", "checked");

    $("#divCheckBoxes_Portfolio :checkbox").change(checkboxFilterOnChange_Portfolio);
    $("#checkbox_HC_Portfolio").attr("checked", "checked");
}

function radioFilterOnChange_Valuation(e) {
    var newSelectedCode = $(this).val();
    if (newSelectedCode != window.selectCode) {
        window.selectCode = $(this).val();
        drawCharts_Valuation();
    }
}

function checkboxFilterOnChange_Portfolio(e) {
    drawCharts_Portfolio();
}

function checkboxFilterOnChange_Weight(e) {
    drawCharts_Weight();
}

function getCheckedValues(parentDiv)
{
    var checkedValues = [];
    $("#"+ parentDiv + " :checked").each(function (index, element) {
        checkedValues.push($(element).val());
    })
    return checkedValues;
}

function setupCharts()
{
    drawCharts();    
}

function mergeTasks() {
    var mergedTasks = [];
    mergedTasks = $.merge(mergedTasks, window.db.tabEvaluation.taskItemStep.TaskItemGroups[2].Tasks);
    mergedTasks = $.merge(mergedTasks, window.db.tabEvaluation.taskItemStep.TaskItemGroups[1].Tasks);
    mergedTasks = $.merge(mergedTasks, window.db.tabEvaluation.taskItemStep.TaskItemGroups[0].Tasks);
    window.db.mergedTasks = mergedTasks;
}

function drawCharts() {
    drawCharts_Weight();
    drawCharts_Valuation();
    drawCharts_Portfolio();
}

function drawCharts_Weight() {

    var data = new google.visualization.DataTable();

    data.addColumn('string', 'Name');
    data.addColumn('number', 'Weight');
    data.addColumn({ type: 'string', role: 'style' });
    data.addColumn({ type: 'string', role: 'annotation' });

    var checkedValues = getCheckedValues('divCheckBoxes_Weight');

    if ($.inArray('HC', checkedValues) > -1) {
        for (var i = 0; i < window.db.tabEvaluation.taskItemStep.TaskItemGroups[0].Tasks.length; i++) {
            data.addRow([window.db.tabEvaluation.taskItemStep.TaskItemGroups[0].Tasks[i].ID + ": " + window.db.tabEvaluation.taskItemStep.TaskItemGroups[0].Tasks[i].Name, window.db.tabEvaluation.taskItemStep.TaskItemGroups[0].Tasks[i].Weight, "color: green", window.db.tabEvaluation.taskItemStep.TaskItemGroups[0].Tasks[i].Weight.toString()]);
        }
    }

    if ($.inArray('SC', checkedValues) > -1) {
        for (var i = 0; i < window.db.tabEvaluation.taskItemStep.TaskItemGroups[1].Tasks.length; i++) {
            data.addRow([window.db.tabEvaluation.taskItemStep.TaskItemGroups[1].Tasks[i].ID + ": " + window.db.tabEvaluation.taskItemStep.TaskItemGroups[1].Tasks[i].Name, window.db.tabEvaluation.taskItemStep.TaskItemGroups[1].Tasks[i].Weight, "color: blue", window.db.tabEvaluation.taskItemStep.TaskItemGroups[1].Tasks[i].Weight.toString()]);
        }
    }

    if ($.inArray('RC', checkedValues) > -1) {
        for (var i = 0; i < window.db.tabEvaluation.taskItemStep.TaskItemGroups[2].Tasks.length; i++) {
            data.addRow([window.db.tabEvaluation.taskItemStep.TaskItemGroups[2].Tasks[i].ID + ": " + window.db.tabEvaluation.taskItemStep.TaskItemGroups[2].Tasks[i].Name, window.db.tabEvaluation.taskItemStep.TaskItemGroups[2].Tasks[i].Weight, "color: red", window.db.tabEvaluation.taskItemStep.TaskItemGroups[2].Tasks[i].Weight.toString()]);
        }
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

    for (var i = 0; i < window.db.tabEvaluation.taskItemStep.TaskItemGroups[taskItemIndex].Tasks.length; i++) {
        data.addRow([window.db.tabEvaluation.taskItemStep.TaskItemGroups[taskItemIndex].Tasks[i].ID + ": " + window.db.tabEvaluation.taskItemStep.TaskItemGroups[taskItemIndex].Tasks[i].Name,
            window.db.tabEvaluation.taskItemStep.TaskItemGroups[taskItemIndex].Tasks[i].Quantity_WeightPercent,
            window.db.tabEvaluation.taskItemStep.TaskItemGroups[taskItemIndex].Tasks[i].Quality_WeightPercent,
            window.db.tabEvaluation.taskItemStep.TaskItemGroups[taskItemIndex].Tasks[i].Systematic_WeightPercent]);
    }
    
    var options = {
        width: 900,
        height: 500,
        title: "Valuation Bar Chart",
        bars: 'horizontal', // Required for Material Bar Charts.
        bar: {
            groupWidth: "90%"
        },
        legend: { position: "Bottom" },
    };

    var chart = new google.visualization.BarChart(document.getElementById('div_ValuationBarChart'));
    chart.draw(data, options);
}

function drawCharts_Portfolio() {

    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Name');
    data.addColumn('number', 'Systematic');
    data.addColumn('number', 'Weight');
    data.addColumn('string', 'Type');
    data.addColumn('number', 'Quantity');

    var checkedValues = getCheckedValues('divCheckBoxes_Portfolio');

    if ($.inArray('HC', checkedValues) > -1) {
        var nIndex = 0;
        for (var i = 0; i < window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks.length; i++) {
            data.addRow([window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].ID + ": " + window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Name,
                window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Systematic_WeightPercent,
                window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Weight,
                'Human Capital',
                window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Quantity_WeightPercent]);
        }
    }

    if ($.inArray('SC', checkedValues) > -1) {
        var nIndex = 1;
        for (var i = 0; i < window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks.length; i++) {
            data.addRow([window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].ID + ": " + window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Name,
                window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Systematic_WeightPercent,
                window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Weight,
                'Structural Captial',
                window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Quantity_WeightPercent]);
        }
    }

    if ($.inArray('RC', checkedValues) > -1) {
        var nIndex = 2;
        for (var i = 0; i < window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks.length; i++) {
            data.addRow([window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].ID + ": " + window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Name,
                window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Systematic_WeightPercent,
                window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Weight,
                'Relationship Capital',
                window.db.tabEvaluation.taskItemStep.TaskItemGroups[nIndex].Tasks[i].Quantity_WeightPercent]);
        }
    }

    var options = {
        width: 900,
        height: 600,
        title: 'Portfolio of Potential',
        hAxis: { title: 'Assessment'},
        vAxis: { title: 'Relative Weighting', minValue: 0, maxValue: 11 },
        bubble: { textStyle: { fontSize: 11 } },
        legend: { position: "none" },        
    };

    var chart = new google.visualization.BubbleChart(document.getElementById('div_PortfolioOfPotential'));
    chart.draw(data, options);
}



