/// <reference path="Workers.js" />
jQuery(document).ready(function ($) {

    //if (typeof (Worker) !== "undefined") {
    //    // Yes! Web worker support!
    //    try {
    //        var worker = new Worker("Workers.js");
    //        worker.addEventListener('error', onError, false);
    //    } catch (e) {
    //        console.log('Error creating the worker.');
    //    }
    //    worker.onmessage = function (event) {
    //        alert('onmessage');
    //    };
    //    worker.onerror = function (event) {
    //        alert('onerror');
    //    };
    //} else {
    //    // Sorry! No Web Worker support..
    //    alert('Sorry! No Web Worker support..');
    //}

    //function onError(e) {
    //    var a = e;
    //}

    $(window).bind('beforeunload', function () {
        if (window.db.IsProjectEditModelChanged === true) {
            return 'You have made some changes on this Project. Please stay on this page to save these changes.';
        }
    });

    $('#a_businessmodel').on('shown.bs.tab', function (e) {
        $('#businessmodel_0').addClass("in active");
    });

    $('#a_swotanalysis').on('shown.bs.tab', function (e) {
        $('#swotanalysis_0').addClass("in active");
    });

    $('#a_businessstrategy').on('shown.bs.tab', function (e) {
        $('#businessstrategy_0').addClass("in active");
    });

    $('#a_successfactors').on('shown.bs.tab', function (e) {
        $('#tab_HumanCaptial').addClass("in active");
    });

    $('#a_evaluation').on('shown.bs.tab', function (e) {
        $('#tab_WeightBarChart').addClass("in active");
    });

    $('#a_hr').on('shown.bs.tab', function (e) {
        $('#hr_0').addClass("in active");
    });

    $('#a_marketing').on('shown.bs.tab', function (e) {
        $('#marketing_0').addClass("in active");
    });

    $('#mainTabs a').click(function (e) {

        e.preventDefault();

        var tabID = $(this).attr("href").substr(1);

        // if this tab has been loaded
        if ($('#' + tabID).children().length > 0)
            return;

        var url = $("#GetTab").val() + "/" + tabID + "?projectId=" + $("#ProjectEdittingId").val();
        var request = $.ajax({
            url: url,
            cache: false,
            type: "get",
            dataType: "html"
        });

        request.done(function (msg) {

            $("#" + tabID).html(msg);

            var element = $("#" + tabID);
            var injector = $('[ng-app]').injector();
            var scope = $('[ng-app]').scope();
            var $compile = injector.get('$compile');
            $compile(element.contents())(scope);
            scope.$digest();
            
        });

        request.fail(function (jqXHR, textStatus) {
            alert("Request failed: " + textStatus);
        });

        $(this).tab('show')

    });

    //#region: Sub Tabs
    //$('#tabs a').click(function (e) {
    //    e.preventDefault();
    //    $(this).tab('show')
    //});
    //#endregion
});

function doSaveMain() {

    if (typeof clearAdditionalProperties_Tab_Charts != 'undefined') {
        clearAdditionalProperties_Tab_Charts();
    };

    var postUrl = $("#UpdateProjectEditModel").val();
    var JSONDataString = JSON.stringify(
            {
                projectEditModel: window.db.projectEditing
            }
        );

    $.ajax({
        url: postUrl,
        type: "POST",
        contentType: "application/json",
        data: JSONDataString,
        success: function (ResponseResult) {
            if (ResponseResult.success == true) {
                bootbox.alert("Project saved successfully!", function () {
                });

                window.db.IsProjectEditModelChanged = false;
                var scope = angular.element($("#divMainProjectEdit")).scope();
                scope.register();
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
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.status);
            alert(thrownError);
        }
    });
}