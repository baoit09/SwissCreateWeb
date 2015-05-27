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
    
    $scope.temp;    
});
