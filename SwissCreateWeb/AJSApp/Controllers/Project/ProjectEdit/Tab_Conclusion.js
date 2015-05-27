jQuery(document).ready(function ($) {
    // Build Tree Structure.
    window.db.Tab_Conclusion_Data = {};
    window.db.Tab_Conclusion_Data.nodes = buildTreeNode();

    // Render Tree
    renderTree();
});

function node(title, description, reportControlName, reportControlLevel, allowMove, children) {
    this.title = title,
    this.description = description,
    this.reportControlName = reportControlName,
    this.reportControlLevel = reportControlLevel,
    this.allowMove = allowMove,
    this.children = [],

    this.key = title,
    this.tooltip = description
}

function buildTreeNode() {

    var nodes = [];

    if (window.db.projectEditing.Project.ReportLayout)
    {
        nodes = JSON.parse(window.db.projectEditing.Project.ReportLayout);
        return nodes;
    }

    var steps = window.db.projectEditing.ProjectData.Periods[0].Steps;
    var projectSetting = window.db.projectSettings;

    //#region Node 1 : Business Model - Swot Analysis - Business Strategy

    var node1 = new node
    (
        steps[projectSetting.Step_BusinessModel_Index].ShortName
            + " - " + steps[projectSetting.Step_SwotAnalysis_Index].ShortName
            + " - " + steps[projectSetting.Step_BusinessStrategy_Index].ShortName,

        steps[projectSetting.Step_BusinessModel_Index].ShortName
            + " - " + steps[projectSetting.Step_SwotAnalysis_Index].ShortName
            + " - " + steps[projectSetting.Step_BusinessStrategy_Index].ShortName,

        "DetailReportStrategyFormulation", 0, true, []
    );
    nodes.push(node1);

    var node11 = new node(steps[projectSetting.Step_BusinessModel_Index].ShortName, steps[projectSetting.Step_BusinessModel_Index].ShortName, "", null, false, {})
    node1.children.push(node11);
    node11.children.push(new node(steps[projectSetting.Step_BusinessModel_Index].FullName, steps[projectSetting.Step_BusinessModel_Index].FullName, "DetailReportBusinessModel", 1, false));
    node11.children.push(new node("Comment " + steps[projectSetting.Step_BusinessModel_Index].FullName, "Comment " + steps[projectSetting.Step_BusinessModel_Index].FullName, "DetailReportBusinessModelCommentary", 1, false));

    var node12 = new node(steps[projectSetting.Step_SwotAnalysis_Index].ShortName, steps[projectSetting.Step_SwotAnalysis_Index].ShortName, "", null, false, [])
    node1.children.push(node12);
    node12.children.push(new node(steps[projectSetting.Step_SwotAnalysis_Index].FullName, steps[projectSetting.Step_SwotAnalysis_Index].FullName, "DetailReportBusinessField", 1, false));
    node12.children.push(new node("Comment " + steps[projectSetting.Step_SwotAnalysis_Index].ShortName, "Comment " + steps[projectSetting.Step_SwotAnalysis_Index].ShortName, "DetailReportBusinessFieldCommentary", 1, false));

    var node13 = new node(steps[projectSetting.Step_BusinessStrategy_Index].ShortName, steps[projectSetting.Step_BusinessStrategy_Index].ShortName, "", null, false, [])
    node1.children.push(node13);
    node13.children.push(new node(steps[projectSetting.Step_BusinessStrategy_Index].FullName, steps[projectSetting.Step_BusinessStrategy_Index].FullName, "DetailReportBusinessPlan", 1, false));
    node13.children.push(new node("Comment " + steps[projectSetting.Step_BusinessStrategy_Index].FullName, "Comment " + steps[projectSetting.Step_BusinessStrategy_Index].FullName, "DetailReportBusinessPlanCommentary", 1, false));

    //#endregion

    //#region Node 2 : SuccesFactors_Review

    var node2 = new node
    (
        steps[projectSetting.Step_SuccessFactors_Index].ShortName
            + " - " + steps[projectSetting.Step_Review_Index].ShortName,

        steps[projectSetting.Step_SuccessFactors_Index].ShortName
            + " - " + steps[projectSetting.Step_Review_Index].ShortName,

        "DetailReportAppendix", 0, true, []
    );

    var node21 = new node(steps[projectSetting.Step_SuccessFactors_Index].ShortName, steps[projectSetting.Step_SuccessFactors_Index].ShortName, "DetailReportSuccessFactors", 1, false, [])
    node2.children.push(node21);
    node21.children.push(new node(steps[projectSetting.Step_SuccessFactors_Index].FullName, steps[projectSetting.Step_SuccessFactors_Index].FullName, "", null, false));
    node21.children.push(new node("Weight", "Weight", "", null, false));
    node21.children.push(new node("Comment " + steps[projectSetting.Step_SuccessFactors_Index].ShortName, "Comment " + steps[projectSetting.Step_SuccessFactors_Index].ShortName, "", null, false));
   
    var node22 = new node(steps[projectSetting.Step_Review_Index].ShortName, steps[projectSetting.Step_Review_Index].ShortName, "DetailReportQQSAppraisal", 1, false, [])
    node2.children.push(node22);
    node22.children.push(new node(steps[projectSetting.Step_Review_Index].FullName, steps[projectSetting.Step_Review_Index].FullName, "", null, false));
    node22.children.push(new node("Comment " + steps[projectSetting.Step_Review_Index].ShortName, "Comment " + steps[projectSetting.Step_Review_Index].ShortName, "", null, false));

    nodes.push(node2);

    //#endregion

    //#region Node 3 : Evaluation

    var node3 = new node
    (
        steps[projectSetting.Step_Evaluation_Index].ShortName,
        steps[projectSetting.Step_Evaluation_Index].ShortName,
        "DetailReportStatusQuoResultFactors", 0, true, []
    )
    nodes.push(node3);
    node3.children.push(new node("Weight Bar Chart", "Weight Bar Chart", "DetailReportImportanceChart", 1, false));
    node3.children.push(new node("Valuation Bar Chart", "Valuation Bar Chart", "DetailReportQQSChart", 1, false));
    node3.children.push(new node("Portfolio of Potential", "Portfolio of Potential", "DetailReportPotentialPortfolioChart", 1, false));
    node3.children.push(new node("Comment " + steps[projectSetting.Step_Evaluation_Index].ShortName, "Comment " + steps[projectSetting.Step_Evaluation_Index].ShortName, "DetailReportSuccessCommentary", 1, false));
    
    //#endregion

    //#region Node 4 : Measures

    var node4 = new node
    (
        steps[projectSetting.Step_Measures_Index].ShortName,
        steps[projectSetting.Step_Measures_Index].ShortName,
        "DetailReportActions", 0, true, []
    );
    nodes.push(node4);

    var node41 = new node(steps[projectSetting.Step_Measures_Index].FullName, steps[projectSetting.Step_Measures_Index].FullName, "DetailReportActionList", 1, false, [])
    node4.children.push(node41);
    node41.children.push(new node("In Planning", "In Planning", "", null, false));
    node41.children.push(new node("In Beginning", "In Beginning", "", null, false));
    node41.children.push(new node("Finished", "Finished", "", null, false));

    var node42 = new node("Comment " + steps[projectSetting.Step_Measures_Index].ShortName, "Comment " + steps[projectSetting.Step_Measures_Index].ShortName, "DetailReportActionListCommentary", 1, false, [])
    node4.children.push(node42);

    //#endregion

    //#region Node 5 : Marketing

    var node5 = new node
    (
        steps[projectSetting.Step_Marketing_Index].ShortName,
        steps[projectSetting.Step_Marketing_Index].ShortName,
        "DetailReport_Marketing,DetailReport_MarketingComment", -1, true, []
    );
    nodes.push(node5);
    node5.children.push(new node(steps[projectSetting.Step_Marketing_Index].FullName, steps[projectSetting.Step_Marketing_Index].FullName, "DetailReport_Marketing", 0, false));
    node5.children.push(new node("Comment " + steps[projectSetting.Step_Marketing_Index].ShortName, "Comment " + steps[projectSetting.Step_Marketing_Index].ShortName, "DetailReport_MarketingComment", 0, false));

    //#endregion

    //#region Node 6 : Financial

    var node6 = new node
    (
        steps[projectSetting.Step_Finance_Index].ShortName,
        steps[projectSetting.Step_Finance_Index].ShortName,
        "DetailReport_Finances_Balance,DetailReport_Finances_Invest,DetailReport_Finances_Price,DetailReport_Finances_Trade,DetailReport_InvestmentPlan,DetailReport_LiquidityPlan,DetailReport_ProfitLossStament,DetailReport_FinanceComment", -1, true, []
    );
    nodes.push(node6);
    node6.children.push(new node("Cockpit Balanced Score Card", "Cockpit Balanced Score Card", "DetailReport_Finances_Balance", 0, false));
    node6.children.push(new node("Investment Calculation", "Investment Calculation", "DetailReport_Finances_Invest", 0, false));
    node6.children.push(new node("Price Calculation", "Price Calculation", "DetailReport_Finances_Price", 0, false));
    node6.children.push(new node("Trade Calculation", "Trade Calculation", "DetailReport_Finances_Trade", 0, false));
    node6.children.push(new node("Investment Plan", "Investment Plan", "DetailReport_InvestmentPlan", 0, false));
    node6.children.push(new node("Liquidity Plan", "Liquidity Plan", "DetailReport_LiquidityPlan", 0, false));
    node6.children.push(new node("Depreciation", "Depreciation", "DetailReport_Depreciation_Calculation", 0, false));
    node6.children.push(new node("Profit and Loss Statment, Budget", "Profit and Loss Statment, Budget", "DetailReport_ProfitLossStament", 0, false));
    node6.children.push(new node("Balance Sheet", "Balance Sheet", "DetailReport_FinanceSheet", 0, false));
    node6.children.push(new node("Comment " + steps[projectSetting.Step_Finance_Index].ShortName, "Comment " + steps[projectSetting.Step_Finance_Index].ShortName, "DetailReport_FinanceComment", 0, false));

    //#endregion

    //#region Node 7 : Risk

    var node7 = new node
    (
        steps[projectSetting.Step_Risk_Index].ShortName,
        steps[projectSetting.Step_Risk_Index].ShortName,
        "DetailReport_Risk,DetailReport_RiskChart,DetailReport_RiskComment", -1, true, []
    )
    nodes.push(node7);
    node7.children.push(new node(steps[projectSetting.Step_Risk_Index].FullName, steps[projectSetting.Step_Risk_Index].FullName, "DetailReport_Risk", 0, false));
    node7.children.push(new node("Chart " + steps[projectSetting.Step_Risk_Index].ShortName, "Chart " + steps[projectSetting.Step_Risk_Index].ShortName, "DetailReport_RiskChart", 0, false));
    node7.children.push(new node("Comment " + steps[projectSetting.Step_Risk_Index].ShortName, "Comment " + steps[projectSetting.Step_Risk_Index].ShortName, "DetailReport_RiskComment", 0, false));

    //#endregion

    //#region Node 8 : Charts

    var node8 = new node
    (
        steps[projectSetting.Step_Charts_Index].ShortName,
        steps[projectSetting.Step_Charts_Index].ShortName,
        "DetailReport_Budget,DetailReport_BudgetChart,DetailReport_BudgetComment", -1, true, []
    )
    nodes.push(node8);
    node8.children.push(new node(steps[projectSetting.Step_Charts_Index].FullName, steps[projectSetting.Step_Charts_Index].FullName, "DetailReport_Budget", 0, false));
    node8.children.push(new node("Chart " + steps[projectSetting.Step_Charts_Index].ShortName, "Chart " + steps[projectSetting.Step_Charts_Index].ShortName, "DetailReport_BudgetChart", 0, false));
    node8.children.push(new node("Comment " + steps[projectSetting.Step_Charts_Index].ShortName, "Comment " + steps[projectSetting.Step_Charts_Index].ShortName, "DetailReport_BudgetComment", 0, false));

    //#endregion

    //#region Node 9 : HR

    var node9 = new node(steps[projectSetting.Step_HR_Index].ShortName, steps[projectSetting.Step_HR_Index].ShortName, "", -1, true, [])
    nodes.push(node9);

    var node91 = new node(steps[projectSetting.Step_HR_Index].FullName, steps[projectSetting.Step_HR_Index].FullName, "", -1, false, [])
    node9.children.push(node91);
    node91.children.push(new node("Job Description", "Job Description", "DetailReport_HumanResource1", 0, false));
    node91.children.push(new node("Employment Contract", "Employment Contract", "DetailReport_HumanResource2", 0, false));
    node91.children.push(new node("Cerificate of Employment", "Cerificate of Employment", "DetailReport_HumanResource3", 0, false));
    node91.children.push(new node("Employment Regulations", "Employment Regulations", "DetailReport_HumanResource4", 0, false));
    node91.children.push(new node("Appraisal Interview", "Appraisal Interview", "DetailReport_HumanResource5", 0, false));

    var node92 = new node("Comment " + steps[projectSetting.Step_Measures_Index].ShortName, "Comment " + steps[projectSetting.Step_Measures_Index].ShortName, "DetailReport_HumanResourceComment", 0, false, [])
    node9.children.push(node92);

    //#endregion

    //#region Node 10 : Conclusion

    var node10 = new node(steps[projectSetting.Step_Conclusion_Index].ShortName, steps[projectSetting.Step_Conclusion_Index].ShortName, "DetailReport_Image,DetailReportBankCommentaries,DetailReport_Appendix", 0, true, [])
    nodes.push(node10);

    var node101 = new node("Summary - Comment " + steps[projectSetting.Step_Conclusion_Index].ShortName, "Summary - Comment " + steps[projectSetting.Step_Conclusion_Index].ShortName, "DetailReportBankCommentaries", false, [])
    node10.children.push(node101);
    node101.children.push(new node("Summary", "Summary", "", null, false));
    node101.children.push(new node("Comment " + steps[projectSetting.Step_Conclusion_Index].ShortName, "Comment " + steps[projectSetting.Step_Conclusion_Index].ShortName, "", null, false));
    

    var node102 = new node("Pictures", "Pictures", "DetailReport_Image", 0, false)
    node10.children.push(node102);

    var node103 = new node("Appendix", "Appendix", "DetailReport_Appendix", 0, false)
    node10.children.push(node103);

    //#endregion

    return nodes;
}

function renderTree() {
    // Create the tree inside the <div id="tree"> element.
    $("#div_fancytree_conclusion_report").fancytree(
    {
        icons: false,
        checkbox: true,
        selectMode: 3,
        keyboard: true, // Support keyboard navigation.
        quicksearch: true, // Navigate to next node by typing the first letters.
        titlesTabbable: true, // Node titles can receive keyboard focus
        source: window.db.Tab_Conclusion_Data.nodes,
        dblclick: function(event, data) {
            data.node.toggleSelected();
        },
        extensions: ["dnd"],
        dnd: {
            autoExpandMS: 400,
            draggable: { // modify default jQuery draggable options
                zIndex: 1000,
                scroll: false,
                revert: "invalid"
            },
            preventVoidMoves: false, // Prevent dropping nodes 'before self', etc.
            preventRecursiveMoves: false, // Prevent dropping nodes on own descendants
            dragStart: function (node, data) {
                // This function MUST be defined to enable dragging for the tree.
                // Return false to cancel dragging of node.
                //    if( data.originalEvent.shiftKey ) ...          

                if (node.data.allowMove === false) {
                    return false;
                }

                return true;
            },
            dragEnter: function (node, data) {
                /* data.otherNode may be null for non-fancytree droppables.
                    * Return false to disallow dropping on node. In this case
                    * dragOver and dragLeave are not called.
                    * Return 'over', 'before, or 'after' to force a hitMode.
                    * Return ['before', 'after'] to restrict available hitModes.
                    * Any other return value will calc the hitMode from the cursor position.
                    */

                // Prevent dropping a parent below another parent (only sort
                // nodes under the same parent):
                if(node.parent !== data.otherNode.parent){
                    return false;
                }

                // Don't allow dropping *over* a node (would create a child). Just
                // allow changing the order:
                return ["before", "after"];

                // Accept everything:
                //return true;
            },
            dragOver: function (node, data) {
            },
            dragLeave: function (node, data) {
            },
            dragStop: function (node, data) {
            },
            dragDrop: function (node, data) {
                // This function MUST be defined to enable dropping of items on the tree.
                // hitMode is 'before', 'after', or 'over'.
                // We could for example move the source to the new target:
                data.otherNode.moveTo(node, data.hitMode);
            }
        }
    }).on("nodeCommand", function (event, data)
    {
        // Custom event handler that is triggered by keydown-handler and
        // context menu:
        var refNode, moveMode,
			tree = $(this).fancytree("getTree"),
			node = tree.getActiveNode();

        if (!node)
            return;

        switch (data.cmd) {
            case "moveUp":
                if (!node.data.allowMove)
                    return;
                refNode = node.getPrevSibling();
                if (refNode) {
                    node.moveTo(refNode, "before");
                    node.setActive();
                }
                break;
            case "moveDown":
                if (!node.data.allowMove)
                    return;
                refNode = node.getNextSibling();
                if (refNode) {
                    node.moveTo(refNode, "after");
                    node.setActive();
                }
                break;
            case "indent":
                refNode = node.getPrevSibling();
                if (refNode) {
                    node.moveTo(refNode, "child");
                    refNode.setExpanded();
                    node.setActive();
                }
                break;
            case "outdent":
                if (!node.isTopLevel()) {
                    node.moveTo(node.getParent(), "after");
                    node.setActive();
                }
                break;
            case "rename":
                node.editStart();
                break;
            case "remove":
                refNode = node.getNextSibling() || node.getPrevSibling() || node.getParent();
                node.remove();
                if (refNode) {
                    refNode.setActive();
                }
                break;
            case "addChild":
                node.editCreateNode("child", "");
                break;
            case "addSibling":
                node.editCreateNode("after", "");
                break;
            case "cut":
                CLIPBOARD = { mode: data.cmd, data: node };
                break;
            case "copy":
                CLIPBOARD = {
                    mode: data.cmd,
                    data: node.toDict(function (n) {
                        delete n.key;
                    })
                };
                break;
            case "clear":
                CLIPBOARD = null;
                break;
            case "paste":
                if (CLIPBOARD.mode === "cut") {
                    // refNode = node.getPrevSibling();
                    CLIPBOARD.data.moveTo(node, "child");
                    CLIPBOARD.data.setActive();
                } else if (CLIPBOARD.mode === "copy") {
                    node.addChildren(CLIPBOARD.data).setActive();
                }
                break;
            default:
                alert("Unhandled command: " + data.cmd);
                return;
        }
    });
}

function checkBoxOnChange(e)
{
    var checked = e.checked;
    if (checked) {
        $("#div_fancytree_conclusion_report").fancytree("getTree").visit(function (node) {
            node.setSelected(true);
        });
    }
    else {
        $("#div_fancytree_conclusion_report").fancytree("getTree").visit(function (node) {
            node.setSelected(false);
        });
    }
}

function doNodeMove_Conclusion(cmdType)
{
    //var tree = $("#div_fancytree_conclusion_report").fancytree("getTree");
    $("#div_fancytree_conclusion_report").trigger("nodeCommand", { cmd: cmdType });
}

function doSaveReportLayout_Conclusion()
{
    var tree = $("#div_fancytree_conclusion_report").fancytree("getTree");
    var nodes = tree.toDict()

    var postUrl = $("#UpdateReportLayout").val();
    var JSONDataString = JSON.stringify({
        projectId : $("#ProjectEdittingId").val(),
        JSONReportLayout: JSON.stringify(nodes)
    });

    $.ajax({
        url: postUrl,
        type: "POST",
        contentType: "application/json",
        data: JSONDataString,
        success: function (ResponseResult) {
            if (ResponseResult.success == true) {
                bootbox.alert("Report layout saved successfully!", function () {
                });
            }
            else {
                bootbox.dialog({
                    message: "Report layout saved failed",
                    title: "Report layout saved",
                    buttons: {
                        danger: {
                            label: "OK",
                            className: "btn-danger"
                        }
                    }
                });
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }
    });
}

function doPrintReportLayout_Conclusion() {

}
