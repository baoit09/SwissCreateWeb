jQuery(document).ready(function ($) {
    // show Risks on grid
    setupJsGrids();

    // show chart
    setupRedips();
});

function setupJsGrids() {
    $("#jsGrid_Risk").jsGrid({
        height: "500px",
        width: "100%",
        //filtering: true,
        editing: true,
        sorting: true,
        paging: true,
        autoload: true,

        pageSize: 15,
        pageButtonCount: 5,

        deleteConfirm: "Do you really want to delete this task?",

        controller: {
            loadData: function (filter) {
                var stepIndex = window.db.projectSettings.Step_Risk_Index;
                var tasks = window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].RiskManagement.Tasks;
                return tasks;
            }
        },

        fields: [
            { name: "RiskNo", type: "number", title: "No", width: 70 },
            { name: "Risk", type: "text", title: "Risk", width: 100 },
            { name: "Impact", type: "select", title: "Impact", items: window.db.projectEditing.ProjectData.Periods[0].Static_E_Risk_Impact_Intance.Intances, valueField: "Mark", textField: "sName" },
            { name: "Probability", type: "select", title: "Probability", items: window.db.projectEditing.ProjectData.Periods[0].Static_E_Risk_Probability_Intance.Intances, valueField: "Mark", textField: "sName" },
            { name: "Manage", type: "text", title: "Measures", width: 120 },
            { type: "control" }
        ],

        onItemUpdated: function (e)
        {
            setupRedips();
        },

        onItemInserted: function (e)
        {
            setupRedips();
        },

        onItemDeleted: function (e) {
            setupRedips();
        }
    });
}

function setupRedips() {

    var table = document.getElementById("table1");
    table.innerHTML = '';
    var vArray = window.db.projectEditing.ProjectData.Periods[0].Static_E_Risk_Probability_Intance.Intances;
    var hArray = window.db.projectEditing.ProjectData.Periods[0].Static_E_Risk_Impact_Intance.Intances;

    var stepIndex = window.db.projectSettings.Step_Risk_Index;
    var tasks = window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].RiskManagement.Tasks;

    // draw Table Frame
    drawTableFrame(table, vArray, hArray);

    // fill cells
    fillCells(tasks, table, vArray, hArray);

    //#region init REDIPS

    // reference to the REDIPS.drag library
    var rd = REDIPS.drag;

    // how to display disabled elements
    rd.style.borderDisabled = 'solid';	// border style for disabled element will not be changed (default is dotted)
    rd.style.opacityDisabled = 60;		// disabled elements will have opacity effect

    // initialization
    rd.init();

    rd.event.changed = function () {
        // get target and source position (method returns positions as array)
        var pos = rd.getPosition();
        var riskNo = rd.obj.innerHTML;
        var newRowIndex = pos[1];
        var newColIndex = pos[2];

        updateCurrentTask(rd, riskNo, newRowIndex, newColIndex, table, tasks, vArray, hArray);
    };

    //#endregion
}

function updateCurrentTask(rd, riskNo, newRowIndex, newColIndex, table, tasks, vArray, hArray)
{
    var task = findFirstTask(tasks, riskNo);

    var newPro = table.rows[newRowIndex].cells[0].innerHTML;
    task.Probability = findFirstProbabilityWithName(vArray, newPro);

    var newImp = table.rows[table.rows.length - 1].cells[newColIndex].innerHTML;
    task.Impact = findFirstImpactWithName(hArray, newImp);
    
    rd.obj.title = getToolTipTask(task, vArray, hArray);

    reFreshJSGrid();
}

function getToolTipTask(task, vArray, hArray)
{
    return task.Risk + '\r' + findFirstProbability(vArray, task.Probability) + "\r" + findFirstImpact(hArray, task.Impact) + "\r" + task.Manage;
}

function reFreshJSGrid()
{
    $("#jsGrid_Risk").jsGrid("loadData");
}

function drawTableFrame(table, vArray, hArray) {
    
    if (table != undefined) {
        // build rows
        var rowCount = vArray.length;
        for (var i = 0; i <= rowCount; i++) {
            var row = table.insertRow(i);

            // build columns
            var colCount = hArray.length;
            for (var j = 0; j <= colCount; j++) {

                var cell = row.insertCell(j);

                if (j == 0) {
                    if (i < rowCount) {
                        var rowIndex = (rowCount - 1) - i;
                        cell.className = 'redips-mark';
                        cell.innerHTML = vArray[rowIndex].sName;
                    }
                }

                if (i == rowCount) {
                    if (j > 0) {
                        var colIndex = j - 1;
                        cell.className = 'redips-mark';
                        cell.innerHTML = hArray[colIndex].sName;
                    }
                }
                
                if (i >= j && j != 0 && i != rowCount) {

                    cell.className = 'white-cell';
                }

                if (i == rowCount && j == 0)
                {
                    cell.className = 'redips-mark';
                }
            }
        }
    }
}

function fillCells(tasks, table, vArray, hArray) {
    var tasksCount = tasks.length;
    for (var i = 0; i < tasksCount; i++) {
        var task = tasks[i];
        fillCell(task, table, vArray, hArray);
    }
}

function fillCell(task, table, vArray, hArray) {

    var pro = findFirstProbability(vArray, task.Probability);
    var imp = findFirstImpact(hArray, task.Impact);
    
    var row = findRowIndex(table, pro);
    var col = findColIndex(table, imp);

    if (row >= 0 && col >= 0)
    {
        var div = $("<div>").addClass("redips-drag t1")
            .attr("title", getToolTipTask(task, vArray, hArray))
            .text(task.RiskNo);
            
        $(table.rows[row].cells[col]).append(div);
    }
}

function findFirstProbability(vArray, mark)
{
    for (var i = 0; i < vArray.length; i++) {
        if (vArray[i].Mark == mark)
            return vArray[i].sName;
    }
    return '';
}

function findFirstProbabilityWithName(vArray, sName) {
    for (var i = 0; i < vArray.length; i++) {
        if (vArray[i].sName == sName)
            return vArray[i].Mark;
    }
    return '';
}

function findFirstImpact(hArray, mark) {
    for (var i = 0; i < hArray.length; i++) {
        if (hArray[i].Mark == mark)
            return hArray[i].sName;
    }
    return '';
}

function findFirstImpactWithName(hArray, sName) {
    for (var i = 0; i < hArray.length; i++) {
        if (hArray[i].sName == sName)
            return hArray[i].Mark;
    }
    return '';
}

function findFirstTask(tasks, riskNo) {
    for (var i = 0; i < tasks.length; i++) {
        if (tasks[i].RiskNo == riskNo)
            return tasks[i];
    }
    return null;
}

function findRowIndex(table, sInnerHTML)
{
    var rowLength = table.rows.length
    for (var row = 0; row < rowLength; row++) {
        if (table.rows[row].cells[0].innerHTML == sInnerHTML)
            return table.rows[row].rowIndex;
    }
    return null;
}

function findColIndex(table, sInnerHTML) {
    var rowLength = table.rows.length
    if (rowLength > 0)
    {
        var colLength = table.rows[0].cells.length;
        for (var col = 0; col < colLength; col++) {
            if (table.rows[rowLength - 1].cells[col].innerHTML == sInnerHTML)
                return table.rows[rowLength - 1].cells[col].cellIndex;
        }
    }
    return null;
}
