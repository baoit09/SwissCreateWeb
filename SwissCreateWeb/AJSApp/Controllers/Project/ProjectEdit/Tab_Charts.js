jQuery(document).ready(function ($) {

    $('#a_charts').on('shown.bs.tab', function (e) {

        if (window.db.tabChart === undefined || window.db.tabChart.tabLoaded === false) {

            initData_TabChart()

            drawBudgetTree();

            window.db.tabChart.tabLoaded = true;
        }
    });

});

function initData_TabChart()
{
    if (window.db.tabChart === undefined) {
        window.db.tabChart = {};
        window.db.tabChart.tabLoaded = false;
        window.db.tabChart.rootBudget = {};
        window.db.tabChart.budgets = [];
        window.db.tabChart.budgetId = 1;
        window.db.tabChart.spanElements = [];
    }
}

//********************* Start: draw tree functions ******************************************

function drawBudgetTree() {

    //#region get root budget and set parent budget for all child budgets.
    var stepIndex = window.db.projectSettings.Step_Charts_Index;
    window.db.tabChart.rootBudget = window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].Budget;
    setParent(window.db.tabChart.rootBudget)
    //#endregion

    //#region clear tree
    var ul = $("#ul_budget_tree");
    ul.html('');
    //#endregion
   
    //#region draw Tree and mapping node with budget (underlying data)
    renderABudget(window.db.tabChart.rootBudget, ul);
    $('.budget-tree li:has(ul)').addClass('parent_li').find(' > span').attr('title', 'Collapse this branch');
    $('.budget-tree li.parent_li > span').on('click', function (e) {
        var children = $(this).parent('li.parent_li').find(' > ul > li');
        if (children.is(":visible")) {
            children.hide('fast');
            $(this).attr('title', 'Expand this branch').find(' > i').removeClass('glyphicon glyphicon-arrow-down').addClass('glyphicon glyphicon-play');
        } else {
            children.show('fast');
            $(this).attr('title', 'Collapse this branch').find(' > i').removeClass('glyphicon glyphicon-play').addClass('glyphicon glyphicon-arrow-down');
        }
        e.stopPropagation();
    });
    addContextMenuHandler();
    //#endregion

    //#region check cost to alarm for all nodes
    checkCostAllBudgets(window.db.tabChart.rootBudget);
    //#endregion
}

function setParent(budget) {
    if (budget != null && budget.Childs != null) {
        budget.budgetId = window.db.tabChart.budgetId++;
        window.db.tabChart.budgets.push(budget);
        var nLength = budget.Childs.length;
        for (var i = 0; i < nLength; i++) {
            budget.Childs[i].parentBudgetId = budget.budgetId;
            setParent(budget.Childs[i]);
        }
    }
}

function findBudget(budgetId)
{
    if (window.db.tabChart.budgets === undefined)
        return null;

    var nLength = window.db.tabChart.budgets.length;
    for (var i = 0; i < nLength; i++) {
        if (window.db.tabChart.budgets[i].budgetId === budgetId)
            return window.db.tabChart.budgets[i];
    }

    return null;
}

function findSpanElement(budgetId) {
    if (window.db.tabChart.spanElements === undefined)
        return null;

    var nLength = window.db.tabChart.spanElements.length;
    for (var i = 0; i < nLength; i++) {
        if (window.db.tabChart.spanElements[i].forBudgetId === budgetId)
            return window.db.tabChart.spanElements[i];
    }

    return null;
}

function renderABudget(budget, ul) {
    if (budget != null && ul != null) {

        //#region Add <li> (Node)
        var li = $('<li/>');
        li.appendTo(ul);

        var span = $('<span/>')
        .attr('data-toggle', 'context')
        .data("budget", budget)
        .addClass('BudgetContextMenu')
        .appendTo(li);
        span[0].forBudgetId = budget.budgetId;
        window.db.tabChart.spanElements.push(span[0]);
        
        var i = $('<i/>')
        .appendTo(span)
        .html(' ' + budget.Name + ' (' + budget.Cost + '$)');
        if (budget.Childs != null && budget.Childs.length > 0) {
            i.addClass('glyphicon glyphicon-play');
        }
        else {
            i.addClass('glyphicon glyphicon-usd');
        }
        //#endregion

        if (budget.Childs != null && budget.Childs.length > 0) {
            var childUL = $('<ul/>');
            childUL.appendTo(li);
            $.each(budget.Childs, function (i, b) {
                renderABudget(b, childUL);
            })
        }
    }
}

function checkCostAllBudgets(budget)
{
    checkCost(budget, false);

    if (budget.Childs != null) {
        var nLength = budget.Childs.length;
        for (var i = 0; i < nLength; i++) {
            checkCost(budget.Childs[i], false);
        }
    }
}

function checkCost(budget, alsoCheckParent) {
    if (budget == null)
        return;

    if (budget.Childs != null && budget.Childs.length > 0) {
        var childTotalAmount = getChildTotalAmount(budget);
        var parentAmount = parseFloat(budget.Cost);
        if (childTotalAmount > parentAmount) {
            var spanElement = findSpanElement(budget.budgetId)
            if(spanElement)
            {
                $(spanElement).attr("style", 'background-color: #ffffcc')
                var sMsg = "Total of children budget (" + childTotalAmount + "$) is greater than total budget (" + parentAmount + "$), please add another number.";
                $(spanElement).find("i").attr("title", sMsg);
            }
        }
        else {
            var spanElement = findSpanElement(budget.budgetId)
            if (spanElement) {
                $(spanElement).attr("style", '')
                $(spanElement).find("i").attr("title", '');
            }
        }
    }

    if (alsoCheckParent) {
        var parentBudget = findBudget(budget.parentBudgetId)
        if (parentBudget != null) {
            checkCost(budget.parentBudgetId)
        }
    }
}

function getChildTotalAmount(budget)
{
    if (budget == null || budget.Childs == null)
        return 0;

    var childTotalAmount = 0;
    $.each(budget.Childs, function (i, e) {
        childTotalAmount += e.Cost;
    });

    return childTotalAmount;
}

function addContextMenuHandler() {
    $('.BudgetContextMenu').contextmenu({
        target: '#context-menu-budget',
        before: function (e, context) {
            // execute code before context menu if shown
            // sender is span on Node
            var sender = $(e.target.parentElement);
            if (lis = $("#ul_budget .NotForUnLeaf")) {

                var budget = sender.data('budget');
                if (budget.Childs == null || budget.Childs.length == 0) { // is leaf node
                    lis.show();                    
                }
                else { // is not leaf node

                    lis.hide();
                }
            }
            return true;
        },
        onItem: function (context, e) {
            // execute on menu item selection
            var menuItemSelected = $(e.target);

            if (!menuItemSelected)
                return;

            var id = menuItemSelected.attr('id');
            switch (id) {
                case "a_budget_addchild":
                    {
                        budget_AddChildBudget(context, e);
                        break;
                    }
                case "a_budget_delete":
                    {
                        budget_DeleteBudget(context, e);
                        break;
                    }
                case "a_budget_change":
                    {
                        budget_ChangeBudget(context, e);
                        break;
                    }

            }
        }
    })
}

//********************* End: draw tree functions *********************************************


//********************* Start: menu context handlers *****************************************

function budget_ChangeBudget(context, e) {

    var nodeSelected = $(context);
    var budget = nodeSelected.data("budget");

    var formContent = "Name: <input type='text' id='name' class='form-control' value='" + (budget.Name == null ? '' : budget.Name) + "'/> <br/>"
                    + "Cost: <input type='text' id='cost' class='form-control' value='" + (budget.Cost == null ? '' : budget.Cost) + "'/> <br/>"
                    + "Note: <input type='text' id='note' class='form-control' value='" + (budget.Note == null ? '' : budget.Note) + "'/>";

    bootbox.dialog({
        message: formContent,
        title: "Change for budget [" + budget.Name + " ] : ",
        buttons: {
            main: {
                label: "Save",
                className: "btn-primary",
                callback: function () {

                    var newName = $('#name').val();
                    var newCost = $('#cost').val()
                    var newNote = $('#note').val()

                    // Need to be check before update to budget
                    if (newName == null || newName == '') {
                        bootbox.dialog({
                            message: "Budget Name could not be empty.",
                            title: "Budget",
                            buttons: {
                                danger: {
                                    label: "OK",
                                    className: "btn-danger"
                                }
                            }
                        });
                        return;
                    }
                    if (newCost == null || newCost == '') {
                        bootbox.dialog({
                            message: "Budget Cost could not be empty.",
                            title: "Budget",
                            buttons: {
                                danger: {
                                    label: "OK",
                                    className: "btn-danger"
                                }
                            }
                        });
                        return;
                    }
                    if (!$.isNumeric(newCost)) {
                        bootbox.dialog({
                            message: "Budget Cost must be amount.",
                            title: "Budget",
                            buttons: {
                                danger: {
                                    label: "OK",
                                    className: "btn-danger"
                                }
                            }
                        });
                        return;
                    }

                    // check success, then update underlying budget.
                    budget.Name = newName;
                    budget.Cost = parseFloat(newCost);
                    budget.Note = newNote;
                    var i = nodeSelected.find("i");
                    i.html(' ' + budget.Name + ' (' + budget.Cost + '$)');

                    // check cost
                    checkCost(budget, true);
                }
            }
        }
    });
}

function budget_AddChildBudget(context, e) {

    var nodeSelected = $(context);
    var parentBudget = nodeSelected.data("budget");

    var childBudget = { Name : "New budget", Cost : 0, Note : null };

    var formContent = "Name: <input type='text' id='name' class='form-control' value='" + (childBudget.Name == null ? '' : childBudget.Name) + "'/> <br/>"
                    + "Cost: <input type='text' id='cost' class='form-control' value='" + (childBudget.Cost == null ? '' : childBudget.Cost) + "'/> <br/>"
                    + "Note: <input type='text' id='note' class='form-control' value='" + (childBudget.Note == null ? '' : childBudget.Note) + "'/>";

    bootbox.dialog({
        message: formContent,
        title: "Add child budget for parent budget [" + parentBudget.Name + " ] : ",
        buttons: {
            main: {
                label: "Save",
                className: "btn-primary",
                callback: function () {

                    childBudget.Name = $('#name').val();
                    childBudget.Cost = $('#cost').val()
                    childBudget.Note = $('#note').val()

                    if (ValidateBudget(childBudget))
                    {
                        childBudget.parentBudgetId = parentBudget.budgetId;

                        parentBudget.Childs.push(childBudget);

                        if (isAutoSumCost()) {
                            var childTotalAmount = getChildTotalAmount(parentBudget);
                            parentBudget.Cost = childTotalAmount;
                        }

                        drawBudgetTree();
                    }
                }
            }
        }
    });
}

function ValidateBudget(budget)
{
    // Need to be check before update to budget
    if (budget.Name == null || budget.Name == '') {
        bootbox.dialog({
            message: "Budget Name could not be empty.",
            title: "Budget",
            buttons: {
                danger: {
                    label: "OK",
                    className: "btn-danger"
                }
            }
        });
        return false;
    }

    if (budget.Cost == null || budget.Cost == '') {
        bootbox.dialog({
            message: "Budget Cost could not be empty.",
            title: "Budget",
            buttons: {
                danger: {
                    label: "OK",
                    className: "btn-danger"
                }
            }
        });
        return false;
    }

    if (!$.isNumeric(budget.Cost)) {
        bootbox.dialog({
            message: "Budget Cost must be amount.",
            title: "Budget",
            buttons: {
                danger: {
                    label: "OK",
                    className: "btn-danger"
                }
            }
        });
        return false;
    }

    budget.Cost = parseFloat(budget.Cost);

    return true;
}

function isAutoSumCost()
{
    return window.db.projectEditing.ProjectData.ConfigData.Config_Budget.AutoSetCostByTotalOfChildren;
}

function budget_DeleteBudget(context, e) {

    var nodeSelected = $(context); // context is span of Node
    var selecteBudget = nodeSelected.data('budget');

    bootbox.dialog({
        message: "Are you sure you want to delete budget [" + selecteBudget.Name + "]?",
        title: "Deleting budget [" + selecteBudget.Name + " ] : ",
        buttons: {
            main: {
                label: "Delete",
                className: "btn-primary",
                callback: function () {

                    var parentBudget = findBudget(selecteBudget.parentBudgetId);
                    var index = parentBudget.Childs.indexOf(selecteBudget)
                    if (index > -1)
                    {
                        parentBudget.Childs.splice(index, 1);
                    }

                    if (isAutoSumCost()) {
                        var childTotalAmount = getChildTotalAmount(parentBudget);
                        parentBudget.Cost = childTotalAmount;
                    }

                    drawBudgetTree();                    
                }
            }
        }
    });
}

//********************* Start: menu context handlers *****************************************



//********************* Start: call before save entire project functions *********************

function clearAdditionalProperties_Tab_Charts(budget) {
    var stepIndex = window.db.projectSettings.Step_Charts_Index;
    var budget = window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].Budget;
    if (budget == null)
        return;

    clearAdditionalProperties_Rec(budget);
}

function clearAdditionalProperties_Rec(budget)
{
    if (budget == null)
        return;

    delete budget.budgetId;
    delete budget.parentBudgetId;
    delete budget.spanElement;

    if (budget.Childs != null) {
        $.each(budget.Childs, function (i, e) {
            clearAdditionalProperties_Rec(e);
        });
    }
}

//********************* End: call before save entire project functions ***********************
