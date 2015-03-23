'use strict';
/* App Module */
var SwissCreateApp = angular.module('SwissCreateApp', []);

/* Controllers */
SwissCreateApp.controller('FileManagerCtrl', function ($scope, $http, $filter) {

    $scope.FileManagerModel;

    $http.post($("#GetProjectCategoryRoot").val(), {})
       .success(function (data, status, headers, config) {
           if (data != null) {
               $scope.FileManagerModel = data;
           }
       })
       .error(function (data, status, headers, config) {
           // log error
       });

    $scope.$watchCollection('[FileManagerModel]', function (newValue, oldValue) {
        var ul = $("#ul_tree");
        $scope.RenderACategory($scope.FileManagerModel.ProjectCategoryRoot, ul);

      
        $('.tree li:has(ul)').addClass('parent_li').find(' > span').attr('title', 'Collapse this branch');

        $('.tree li.parent_li > span').on('click', function (e) {
            var children = $(this).parent('li.parent_li').find(' > ul > li');
            if (children.is(":visible")) {
                children.hide('fast');
                $(this).attr('title', 'Expand this branch').find(' > i').removeClass('glyphicon glyphicon-folder-open').addClass('glyphicon glyphicon-folder-close');
            } else {
                children.show('fast');
                $(this).attr('title', 'Collapse this branch').find(' > i').removeClass('glyphicon glyphicon-folder-close').addClass('glyphicon glyphicon-folder-open');
            }
            e.stopPropagation();
        });

    });

    
    $scope.RenderACategory = function (cat, ul) {
        if (cat != null)
        {
            //#region Add <li>
            var li = $('<li/>');
            li.appendTo(ul);

            var span = $('<span/>')
            .attr('data-toggle', 'context')
            .attr('data-type', 'category')
            .attr('data-id', cat.Id)
            .addClass('FolderContextMenu')
            .appendTo(li);

            var i = $('<i/>')
            .addClass('glyphicon glyphicon-folder-open')
            .appendTo(span)
            .html(' ' + cat.Name)
            //#endregion

            var childUL = $('<ul/>');
            childUL.appendTo(li);
           
            if (cat.Projects != null && cat.Projects.length > 0)
            {
                $.each(cat.Projects, function (i, project)
                {
                    //#region add <li>
                    var li = $('<li/>');
                    li.appendTo(childUL);

                    var span = $('<span/>')
                    .attr('data-toggle', 'context')
                    .attr('data-type', 'project')
                    .attr('data-id', project.Id)
                    .attr('style', 'background-color:antiquewhite')
                    .addClass('FileContextMenu')
                    .appendTo(li);

                    var i = $('<i/>')
                    .addClass('glyphicon glyphicon-file')
                    .appendTo(span)
                    .html(' ' + project.Name)
                    //#endregion
                })
            }

            if (cat.ChildProjectCategories != null && cat.ChildProjectCategories.length > 0) {
                $.each(cat.ChildProjectCategories, function (i, cat) {
                    $scope.RenderACategory(cat, childUL);
                })
            }
        }
    }
});
