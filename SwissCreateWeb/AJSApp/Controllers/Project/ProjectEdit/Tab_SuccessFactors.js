$(document).ready(function () {

    $('#a_successfactors').on('shown.bs.tab', function (e)
    {
        if (window.db.tabSuccessFactors === undefined || window.db.tabSuccessFactors.tabLoaded === false)
        {
            initData_TabSuccessFactors();

            setupJsGridsSuccessFactors();

            window.db.tabSuccessFactors.tabLoaded = true;
        }
    });
});

function initData_TabSuccessFactors()
{
    if (window.db.tabSuccessFactors === undefined) {
        window.db.tabSuccessFactors = {};
        window.db.tabSuccessFactors.tabLoaded = false;        
    }
}

function setupJsGridsSuccessFactors()
{
    var stepIndex = window.db.projectSettings.Step_SuccessFactors_Index;

    $("#jsGrid_HumanCaptial").jsGrid({
        height: "auto",
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
                return window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].TaskItemStep.TaskItemGroups[0].Tasks;
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
    
    $("#jsGrid_StructuralCapital").jsGrid({
        height: "auto",
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
                return window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].TaskItemStep.TaskItemGroups[1].Tasks;
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
        height: "auto",
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
                return window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].TaskItemStep.TaskItemGroups[2].Tasks;
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
        height: "auto",
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
                mergedTasks = $.merge(mergedTasks, window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].TaskItemStep.TaskItemGroups[0].Tasks);
                mergedTasks = $.merge(mergedTasks, window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].TaskItemStep.TaskItemGroups[1].Tasks);
                mergedTasks = $.merge(mergedTasks, window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].TaskItemStep.TaskItemGroups[2].Tasks);
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



