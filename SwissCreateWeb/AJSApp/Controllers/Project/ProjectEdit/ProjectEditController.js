'use strict';
/* App Module */
var SwissCreateApp = angular.module('SwissCreateApp', []);

SwissCreateApp.filter('jsonDate', function ($filter) {
    return function (input, format) {
        return $filter('date')(parseInt(input.substr(6)), format);
    };
});

/* Controllers */
SwissCreateApp.controller('ProjectCtrl', function ($scope, $http, $filter) {

    //#region Data
    $scope.ProjectEditModel = window.db.projectEditing;
    $scope.ProjectModel = window.db.projectEditing.Project;
    $scope.ProjectData = window.db.projectEditing.ProjectData;
    //endregion
    

    //#region Get Data
    //$http.post($("#GetProjectEditModel").val(),
    //    { "projectId": $("#ProjectEdittingId").val()})
    //   .success(function (data, status, headers, config) {
    //       if (data != null) {
    //           $scope.ProjectEditModel = data;
    //           $scope.ProjectModel = data.Project;
    //           $scope.ProjectData = data.ProjectData;
    //       }
    //   })
    //   .error(function (data, status, headers, config) {
    //       // log error
    //   });
    //endregion
});
