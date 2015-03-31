jQuery(document).ready(function ($) {

    $(".tabQA").ready(function () {
        $(".tabQA li a").click(function () {
            var id = $(this).attr("id");
            var groupindex = $(this).data("groupindex");
            var questionindex = $(this).data("questionindex");
            var questiontext = $(this).data("questiontext");

            var projectId = $("#Hidden_ProjectId").val();
            var stepIndex = $("#Hidden_StepIndex").val();

            switch (id) {
                case "a_Delete":
                    {
                        doDelete(projectId, stepIndex, groupindex, questionindex, questiontext);
                        break;
                    }
                case "a_MoveUp":
                    {
                        doMoveUp(projectId, stepIndex, groupindex, questionindex, questiontext);
                        break;
                    }
                case "a_MoveDown":
                    {
                        doMoveDown(projectId, stepIndex, groupindex, questionindex, questiontext);
                        break;
                    }
                case "a_MoveTop":
                    {
                        doMoveTop(projectId, stepIndex, groupindex, questionindex, questiontext);
                        break;
                    }
                case "a_MoveBottom":
                    {
                        doMoveBottom(projectId, stepIndex, groupindex, questionindex, questiontext);
                        break;
                    }
                    
            }
        });

        $(".tabQA .btnAddNewQA").click(function () {
            
            var projectId = $("#Hidden_ProjectId").val();
            var stepIndex = $("#Hidden_StepIndex").val();
            var groupindex = $(this).data("groupindex");

            doAddNewQA(projectId, stepIndex, groupindex);
        });
        
    });
    
    function doDelete(projectId, stepIndex, groupindex, questionindex, questiontext)
    {
        bootbox.dialog({
            message: "Delete answer, or delete question, or delete both for question: <br>[" + questiontext + "]?",
            title: "Confirm",
            buttons: {
                answer: {
                    label: "Delete Question",
                    className: "btn-primary",
                    callback: function () {
                        var option = "question";
                        doDeletePost(projectId, stepIndex, groupindex, questionindex, option)
                    }
                },
                quesion: {
                    label: "Delete Answer",
                    className: "btn-primary",
                    callback: function () {
                        var option = "answer";
                        doDeletePost(projectId, stepIndex, groupindex, questionindex, option)
                    }
                },
                both: {
                    label: "Delete Both",
                    className: "btn-primary",
                    callback: function () {
                        var option = "both";
                        doDeletePost(projectId, stepIndex, groupindex, questionindex, option)
                    }
                },
                cancel: {
                    label: "Cancel",
                    className: "btn-primary",
                    callback: function () {                        
                    }
                },
            }
        });
    }

    function doDeletePost(projectId, stepIndex, groupindex, questionindex, option)
    {
        // Post data to server
        var url = $("#Hidden_DeleteQuestionAnswer").val();
        $.post(url,
            {
                "projectId": projectId,
                "stepIndex": stepIndex,
                "groupindex": groupindex,
                "questionindex": questionindex,
                "option": option,
            },
            function (ResponseResult) {
                if (ResponseResult.success == true) {
                    window.location.href = $("#Hidden_OpenProject").val() + "?projectId=" + projectId;
                }
                else {
                    bootbox.dialog({
                        message: "Delete failed",
                        title: "Delete Question",
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

    function doMoveUp(projectId, stepIndex, groupindex, questionindex, questiontext) {

        bootbox.confirm("Are you sure you want to move UP question: <br> [" + questiontext + " ] ?", function (result) {
            if (result == true) {
                // Post data to server
                var url = $("#Hidden_MoveQuestionAnswer").val();
                $.post(url,
                    {
                        "projectId": projectId,
                        "stepIndex": stepIndex,
                        "groupindex": groupindex,
                        "questionindex": questionindex,
                        "option": 'Up',
                    },
                    function (ResponseResult) {
                        if (ResponseResult.success == true) {
                            window.location.href = $("#Hidden_OpenProject").val() + "?projectId=" + projectId;
                        }
                        else {
                            bootbox.dialog({
                                message: "Move question failed",
                                title: "Move Question",
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
        })
    }

    function doMoveDown(projectId, stepIndex, groupindex, questionindex, questiontext) {
        bootbox.confirm("Are you sure you want to move DOWN question: <br> [" + questiontext + " ] ?", function (result) {
            if (result == true) {
                // Post data to server
                var url = $("#Hidden_MoveQuestionAnswer").val();
                $.post(url,
                    {
                        "projectId": projectId,
                        "stepIndex": stepIndex,
                        "groupindex": groupindex,
                        "questionindex": questionindex,
                        "option": 'Down',
                    },
                    function (ResponseResult) {
                        if (ResponseResult.success == true) {
                            window.location.href = $("#Hidden_OpenProject").val() + "?projectId=" + projectId;
                        }
                        else {
                            bootbox.dialog({
                                message: "Move question failed",
                                title: "Move Question",
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
        })
    }

    function doMoveTop(projectId, stepIndex, groupindex, questionindex, questiontext) {

        bootbox.confirm("Are you sure you want to move TOP question: <br> [" + questiontext + " ] ?", function (result) {
            if (result == true) {
                // Post data to server
                var url = $("#Hidden_MoveQuestionAnswer").val();
                $.post(url,
                    {
                        "projectId": projectId,
                        "stepIndex": stepIndex,
                        "groupindex": groupindex,
                        "questionindex": questionindex,
                        "option": 'Top',
                    },
                    function (ResponseResult) {
                        if (ResponseResult.success == true) {
                            window.location.href = $("#Hidden_OpenProject").val() + "?projectId=" + projectId;
                        }
                        else {
                            bootbox.dialog({
                                message: "Move question failed",
                                title: "Move Question",
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
        })
    }

    function doMoveBottom(projectId, stepIndex, groupindex, questionindex, questiontext) {

        bootbox.confirm("Are you sure you want to move BOTTOM question: <br> [" + questiontext + " ] ?", function (result) {
            if (result == true) {
                // Post data to server
                var url = $("#Hidden_MoveQuestionAnswer").val();
                $.post(url,
                    {
                        "projectId": projectId,
                        "stepIndex": stepIndex,
                        "groupindex": groupindex,
                        "questionindex": questionindex,
                        "option": 'Bottom',
                    },
                    function (ResponseResult) {
                        if (ResponseResult.success == true) {
                            window.location.href = $("#Hidden_OpenProject").val() + "?projectId=" + projectId;
                        }
                        else {
                            bootbox.dialog({
                                message: "Move question failed",
                                title: "Move Question",
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
        })
    }

    function doAddNewQA(projectId, stepIndex, groupIndex) {

        bootbox.prompt("Enter new question :", function (result) {
            if (result === null) { }
            else
            { // Post data to server
                var url = $("#Hidden_AddNewQuestionAnswer").val();
                $.post(url,
                    {
                        "projectId": projectId,
                        "stepIndex": stepIndex,
                        "groupIndex": groupIndex,
                        "questionText": result
                    },
                    function (ResponseResult) {
                        if (ResponseResult.success == true)
                        {
                            window.location.href = $("#Hidden_OpenProject").val() + "?projectId=" + projectId;
                        }
                        else {
                            bootbox.dialog({
                                message: "File [" + result + "] failed to add.",
                                title: "File Manager",
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
        });
    }
});

