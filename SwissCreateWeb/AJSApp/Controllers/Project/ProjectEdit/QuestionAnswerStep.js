jQuery(document).ready(function ($) {

    var bNeedConfirmWhenMove = false;

    $(".tabQA").ready(function () {
        AddButtonEventHanlders();
    });
    
    function AddButtonEventHanlders()
    {
        $(".tabQA li a").off('click');
        $(".tabQA li a").click(function () {
            var id = $(this).attr("id");
            var groupIndex = $(this).data("groupindex");
            var questionIndex = $(this).data("questionindex");
            var questionText = $(this).data("questiontext");
            var stepIndex = $(this).data("stepindex");

            var projectId = $("#Hidden_ProjectId").val();
           
            switch (id) {
                case "a_Delete":
                    {
                        doDelete(projectId, stepIndex, groupIndex, questionIndex, questionText);
                        break;
                    }
                case "a_MoveUp":
                    {
                        doMoveUp(projectId, stepIndex, groupIndex, questionIndex, questionText);
                        break;
                    }
                case "a_MoveDown":
                    {
                        doMoveDown(projectId, stepIndex, groupIndex, questionIndex, questionText);
                        break;
                    }
                case "a_MoveTop":
                    {
                        doMoveTop(projectId, stepIndex, groupIndex, questionIndex, questionText);
                        break;
                    }
                case "a_MoveBottom":
                    {
                        doMoveBottom(projectId, stepIndex, groupIndex, questionIndex, questionText);
                        break;
                    }

            }
        });

        $(".btnAddNewQA").off('click');
        $(".btnAddNewQA").click(function () {

            var projectId = $("#Hidden_ProjectId").val();
            var stepIndex = $(this).data("stepindex");
            var groupIndex = $(this).data("groupindex");

            doAddNewQA(projectId, stepIndex, groupIndex);
        });
    }

    function doDelete(projectId, stepIndex, groupIndex, questionIndex, questionText)
    {
        bootbox.dialog({
            message: "Delete answer, or delete question, or delete both for question: <br>[" + questionText + "]?",
            title: "Confirm",
            buttons: {
                answer: {
                    label: "Delete Question",
                    className: "btn-primary",
                    callback: function () {
                        var option = "question";
                        doDeletePost(projectId, stepIndex, groupIndex, questionIndex, option)
                    }
                },
                quesion: {
                    label: "Delete Answer",
                    className: "btn-primary",
                    callback: function () {
                        var option = "answer";
                        doDeletePost(projectId, stepIndex, groupIndex, questionIndex, option)
                    }
                },
                both: {
                    label: "Delete Both",
                    className: "btn-primary",
                    callback: function () {
                        var option = "both";
                        doDeletePost(projectId, stepIndex, groupIndex, questionIndex, option)
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

    function doDeletePost(projectId, stepIndex, groupIndex, questionIndex, option)
    {
        var scope = angular.element($("#divQAMain")).scope();
        scope.$apply(function () {
            var currentQA = scope.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers[questionIndex];
            if (option == "question") {
                currentQA.Question = '';
            }
            else if (option == "answer") {
                currentQA.Answer = '';
            }
            else if (option == "both") {
                window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers.splice(questionIndex, 1);
            }
        });
    }

    function doMoveUp(projectId, stepIndex, groupIndex, questionIndex, questionText) {

        if(bNeedConfirmWhenMove)
        {
            bootbox.confirm("Are you sure you want to move UP question: <br> [" + questionText + " ] ?", function (result) {
                if (result == true)            {
                    doMoveQuestion(stepIndex, groupIndex, questionIndex, "Up")
                }
            })
        }
        else
        {
            doMoveQuestion(stepIndex, groupIndex, questionIndex, "Up")
        }
    }

    function doMoveDown(projectId, stepIndex, groupIndex, questionIndex, questionText) {

        if(bNeedConfirmWhenMove)
        {
            bootbox.confirm("Are you sure you want to move DOWN question: <br> [" + questionText + " ] ?", function (result) {
                if (result == true) {
                    doMoveQuestion(stepIndex, groupIndex, questionIndex, "Down")
                }
            })
        }
        else
        {
            doMoveQuestion(stepIndex, groupIndex, questionIndex, "Down")
        }
    }

    function doMoveTop(projectId, stepIndex, groupIndex, questionIndex, questionText) {

        if(bNeedConfirmWhenMove)
        {
            bootbox.confirm("Are you sure you want to move TOP question: <br> [" + questionText + " ] ?", function (result) {
                if (result == true) {
                    doMoveQuestion(stepIndex, groupIndex, questionIndex, "Top");
                }
            })
        }
        else
        {
            doMoveQuestion(stepIndex, groupIndex, questionIndex, "Top");
        }
    }

    function doMoveBottom(projectId, stepIndex, groupIndex, questionIndex, questionText) {

        if(bNeedConfirmWhenMove)
        {
            bootbox.confirm("Are you sure you want to move BOTTOM question: <br> [" + questionText + " ] ?", function (result) {
                if (result == true) {
                    doMoveQuestion(stepIndex, groupIndex, questionIndex, "Bottom");
                }
            })
        }
        else
        {
            doMoveQuestion(stepIndex, groupIndex, questionIndex, "Bottom");
        }
    }

    function doAddNewQA(projectId, stepIndex, groupIndex) {

        bootbox.prompt("Enter new question :", function (result) {
            if (result === null) { }
            else
            {
                var newQA = { Question: result, Answer: '' };
               
                var scope = angular.element($("#divQAMain")).scope();
                scope.$apply(function () {
                    scope.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers.push(newQA);
                })

                AddButtonEventHanlders();
            }
        });
    }

    function doMoveQuestion(stepIndex, groupIndex, questionIndex, option)
    {
        var qas = $(window.db.projectEditing.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers);
        var nLength = qas.length;

        if (option == "Up")
        {
            if (questionIndex == 0)
            {
                return; 
            }
            else
            {
                var scope = angular.element($("#divQAMain")).scope();
                scope.$apply(function () {
                   
                    var currentQA = scope.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers[questionIndex];
                    var previousQA = scope.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers[(questionIndex - 1)];

                    var sQuestion = currentQA.Question;
                    var sAnswer = currentQA.Answer;

                    currentQA.Question = previousQA.Question;
                    currentQA.Answer = previousQA.Answer;

                    previousQA.Question = sQuestion;
                    previousQA.Answer = sAnswer;

                })
            }
        }
        else if (option == "Down")
        {
            if (questionIndex == nLength - 1)
            {
                return;
            }
            else
            {
                var scope = angular.element($("#divQAMain")).scope();
                scope.$apply(function () {

                    var currentQA = scope.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers[questionIndex];
                    var nextQA = scope.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers[(questionIndex + 1)];

                    var sQuestion = currentQA.Question;
                    var sAnswer = currentQA.Answer;

                    currentQA.Question = nextQA.Question;
                    currentQA.Answer = nextQA.Answer;

                    nextQA.Question = sQuestion;
                    nextQA.Answer = sAnswer;

                });
                
            }
        }
        else if (option == "Top")
        {
            if (questionIndex == 0)
            {
                return;
            }
            else
            {
                var scope = angular.element($("#divQAMain")).scope();
                scope.$apply(function () {
                    var currentQA = scope.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers[questionIndex];
                    var previousQA = scope.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers[0];

                    var sQuestion = currentQA.Question;
                    var sAnswer = currentQA.Answer;

                    currentQA.Question = previousQA.Question;
                    currentQA.Answer = previousQA.Answer;

                    previousQA.Question = sQuestion;
                    previousQA.Answer = sAnswer;
                });
                
            }
        }
        else if (option == "Bottom")
        {
            if (questionIndex == nLength - 1)
            {
                return;
            }
            else
            {
                var scope = angular.element($("#divQAMain")).scope();
                scope.$apply(function () {
                    var currentQA = scope.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers[questionIndex];
                    var nextQA = scope.ProjectData.Periods[0].Steps[stepIndex].QuestionAnwserStep.QuestionAnwserGroups[groupIndex].QuestionAnswers[(nLength - 1)];

                    var sQuestion = currentQA.Question;
                    var sAnswer = currentQA.Answer;

                    currentQA.Question = nextQA.Question;
                    currentQA.Answer = nextQA.Answer;

                    nextQA.Question = sQuestion;
                    nextQA.Answer = sAnswer;
                });                
            }
        }        
    }
       
});

function goto() {
    return false;
}

