'use strict';
/* App Module */
var SwissCreateApp = angular.module('SwissCreateApp', []);

SwissCreateApp.filter('jsonDate', function ($filter) {
    return function (input, format) {
        return $filter('date')(parseInt(input.substr(6)), format);
    };
});

SwissCreateApp.filter('toBooleanForStepResult', function ($filter) {
    return function (input, valueForTrue) {
        return input == valueForTrue;
    };
});

/* Controllers */
SwissCreateApp.controller('ProjectCtrl', function ($scope, $http, $filter) {

    //#region Data
    $scope.ProjectEditModel = window.db.projectEditing;
    $scope.ProjectModel = window.db.projectEditing.Project;
    $scope.ProjectData = window.db.projectEditing.ProjectData;
    //endregion

    $scope.setParent = function (budget) {
        if (budget != null && budget.Childs != null) {
            var nLength = budget.Childs.length;
            for (var i = 0; i < nLength; i++) {
                budget.Childs[i].parentBudget = budget;
                setParent(budget.Childs[i]);
            }
        }
    };

    //#region Button Save Project
    $scope.register = function ()
    {
        $scope.unregister = $scope.$watch('ProjectEditModel', function (oldValue, newValue) {

            if (window.db.IsProjectEditModelChanged === undefined) {
                window.db.IsProjectEditModelChanged = false;
                return;
            }

            if (window.db.IsProjectEditModelChanged === false) {
                window.db.IsProjectEditModelChanged = true;
                $scope.unregister();
            }

        }, true);
    }
    $scope.register();
    //#endregion   
    
    $scope.temp = 1;
});
