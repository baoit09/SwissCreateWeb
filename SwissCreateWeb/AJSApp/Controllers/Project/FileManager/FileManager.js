var storage = window.localStorage;
$(document).ready(function () {

});

//#region Folder Context Menu

$('.FolderContextMenu').contextmenu({
    target: '#context-menu-folder',
    before: function (e, context) {
        // execute code before context menu if shown
        var sender = $(e.target);
        if (lis = $("#ul_folder .NotForRoot")) {
            var catId = sender.data("id");
            catId == 0 ? lis.hide() : lis.show();
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
            case "a_folder_addChildFolder":
                {
                    folder_AddChildFolder(context, e);
                    break;
                }
            case "a_folder_addChildFile":
                {
                    folder_AddChildFile(context, e);
                    break;
                }
            case "a_folder_deleteFolder":
                {
                    folder_DeleteFolder(context, e);
                    break;
                }
            case "a_folder_changeFolderName":
                {
                    folder_ChangeFolderName(context, e);
                    break;
                }

        }
    }
})

function folder_AddChildFolder(context, e) {
    var nodeSelected = $(context);
    var parentCateId = nodeSelected.data('id');

    bootbox.prompt("Enter child folder name for folder [" + nodeSelected.text() + " ] :", function (result) {
        if (result === null) { }
        else
        { // Post data to server
            var url = $("#AddChildProjectCategory").val();
            $.post(url, { "parentCategoryId": parentCateId, "childFolderName": result },
				function (ResponseResult) {
				    if (ResponseResult.success == true) {
				        //bootbox.dialog({
				        //	message: "Folder [ " + result + " ] has been added.",
				        //	title: "File Manager",
				        //	buttons: {
				        //		success: {
				        //			label: "OK",
				        //			className: "btn-success",
				        //			callback: function () {
				        //				window.location.href = '/Project/FileManager';
				        //			}
				        //		}								
				        //	}
				        //});

				        window.location.href = $("#GetFileManager").val();
				    }
				    else {
				        bootbox.dialog({
				            message: "Folder [ " + result + " ] failed to add.",
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

function folder_AddChildFile(context, e) {
    var nodeSelected = $(context);
    var parentCateId = nodeSelected.data('id');

    var select = "";
    var templates = $("#Templates").val();
    if (templates.length > 0)
    {
        var items = templates.split(",");
        select = " <select id='select_template' style='margin-top:5px' class='form-control'> "
        $.each(items, function (key, value) {
            select += " <option value='" + value + "'>" + value + "</option> ";
        });
        select += " </select> "
    }

    bootbox.dialog({
        message: "<input type='text' id='first_name' class='form-control'></input>" + select,
        title: "Enter file name for folder [" + nodeSelected.text() + " ] : ",
        buttons: {
            main: {
                label: "Save",
                className: "btn-primary",
                callback: function () {
                    // Post data to server
                    var url = $("#AddProject").val();
                    $.post(url,
                        {
                            "parentCategoryId": parentCateId,
                            "childFileName": $('#first_name').val(),
                            "selectTemplate": $('#select_template').val(),
                        },
	                	function (ResponseResult) {
	                	    if (ResponseResult.success == true) {
	                	        window.location.href = $("#GetFileManager").val();
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
            }
        }
    });

    //bootbox.prompt("Enter file name for folder [" + nodeSelected.text() + " ] :", function (result) {
    //	if (result === null) { }
    //	else
    //	{ // Post data to server
    //		var url = $("#AddProject").val();
    //		$.post(url, { "parentCategoryId": parentCateId, "childFileName": result },
    //			function (ResponseResult) {
    //				if (ResponseResult.success == true) {
    //				    window.location.href = $("#GetFileManager").val();
    //				}
    //				else {
    //					bootbox.dialog({
    //						message: "File [" + result + "] failed to add.",
    //						title: "File Manager",
    //						buttons: {
    //							danger: {
    //								label: "OK",
    //								className: "btn-danger"
    //							}
    //						}
    //					});
    //				}
    //			});
    //	}
    //});
}

function folder_DeleteFolder(context, e) {
    var nodeSelected = $(context);
    var parentCateId = nodeSelected.data('id');

    bootbox.confirm("Are you sure you want to delete folder [" + nodeSelected.text() + " ] ?", function (result) {
        if (result == true) {
            // Post data to server
            var url = $("#DeleteProjectCategory").val();
            $.post(url, { "projectCategoryId": parentCateId },
				function (ResponseResult) {
				    if (ResponseResult.success == true) {
				        //bootbox.dialog({
				        //	message: "Folder [" + nodeSelected[0].innerText + "] has been deleted.",
				        //	title: "File Manager",
				        //	buttons: {
				        //		success: {
				        //			label: "OK",
				        //			className: "btn-success",
				        //			callback: function () {
				        //				window.location.href = '/Project/FileManager';
				        //			}
				        //		}
				        //	}
				        //});

				        window.location.href = $("#GetFileManager").val();
				    }
				    else {
				        bootbox.dialog({
				            message: "Folder [" + nodeSelected.text() + " ] failed to delete. Folder should be empty.",
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
    })
}

function folder_ChangeFolderName(context, e) {

    var nodeSelected = $(context);
    var parentCateId = nodeSelected.data('id');

    bootbox.prompt({
        title: "Enter new folder name for folder [ " + nodeSelected.text() + " ] : ",
        value: "",
        callback: function (result) {
            if (result === null) {
            } else {
                // Post data to server
                var url = $("#ChangeProjectCategoryName").val();
                $.post(url, { "projectCategoryId": parentCateId, "newName": result },
					function (ResponseResult) {
					    if (ResponseResult.success == true) {
					        //bootbox.dialog({
					        //	message: "Folder [ " + result + " ] has been added.",
					        //	title: "File Manager",
					        //	buttons: {
					        //		success: {
					        //			label: "OK",
					        //			className: "btn-success",
					        //			callback: function () {
					        //				window.location.href = '/Project/FileManager';
					        //			}
					        //		}								
					        //	}
					        //});

					        window.location.href = $("#GetFileManager").val();
					    }
					    else {
					        bootbox.dialog({
					            message: "Change name of folder [" + nodeSelected.text() + " ] failed. The new folder name must differ with the old name",
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
        }
    });
}

//#endregion

//#region File Context Menu

$('.FileContextMenu').contextmenu({
    target: '#context-menu-file',
    before: function (e, context) {
        return true;
    },
    onItem: function (context, e) {
        // execute on menu item selection
        // execute on menu item selection
        var menuItemSelected = $(e.target);

        if (!menuItemSelected)
            return;

        var id = menuItemSelected.attr('id');
        switch (id) {
            case "a_file_openProject":
                {
                    file_OpenProject(context, e);
                    break;
                }
            case "a_file_uploadProjectData":
                {
                    file_UploadProjectData(context, e);
                    break;
                }
            case "a_file_downloadProjectData":
                {
                    file_DownloadProjectData(context, e);
                    break;
                }
            case "a_file_changeFileName":
                {
                    file_ChangeFileName(context, e);
                    break;
                }
            case "a_file_deleteFile":
                {
                    file_DeleteFile(context, e);
                    break;
                }
        }
    }
})

function file_DeleteFile(context, e) {
    var nodeSelected = $(context);
    var parentCateId = nodeSelected.data('id');

    bootbox.confirm("Are you sure you want to delete file [" + nodeSelected.text() + "] ?", function (result) {
        if (result == true) {
            // Post data to server
            var url = $("#DeleteProject").val();
            $.post(url, { "projectId": parentCateId },
				function (ResponseResult) {
				    if (ResponseResult.success == true) {
				        //bootbox.dialog({
				        //	message: "File [" + nodeSelected[0].innerText + "] has been deleted.",
				        //	title: "File Manager",
				        //	buttons: {
				        //		success: {
				        //			label: "OK",
				        //			className: "btn-success",
				        //			callback: function () {
				        //				window.location.href = '/Project/FileManager';
				        //			}
				        //		}
				        //	}
				        //});

				        window.location.href = $("#GetFileManager").val();
				    }
				    else {
				        bootbox.dialog({
				            message: "File [" + nodeSelected.text() + " ] failed to delete.",
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
    })
}

function file_ChangeFileName(context, e) {

    var nodeSelected = $(context);
    var parentCateId = nodeSelected.data('id');

    bootbox.prompt({
        title: "Enter new file name for file [" + nodeSelected.text() + " ] :",
        value: "",
        callback: function (result) {
            if (result === null) {
            } else {
                // Post data to server
                var url = $("#ChangeProjectName").val();
                $.post(url, { "projectId": parentCateId, "newName": result },
					function (ResponseResult) {
					    if (ResponseResult.success == true) {
					        //bootbox.dialog({
					        //	message: "Folder [ " + result + " ] has been added.",
					        //	title: "File Manager",
					        //	buttons: {
					        //		success: {
					        //			label: "OK",
					        //			className: "btn-success",
					        //			callback: function () {
					        //				window.location.href = '/Project/FileManager';
					        //			}
					        //		}								
					        //	}
					        //});

					        window.location.href = $("#GetFileManager").val();
					    }
					    else {
					        bootbox.dialog({
					            message: "Change name of file [" + nodeSelected.text() + " ] failed.",
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
        }
    });
}

function file_OpenProject(context, e) {

    var nodeSelected = $(context);
    var projectId = nodeSelected.data('id');

    window.location.href = $("#OpenProject").val() + "?ProjectId=" + projectId;
}

function file_UploadProjectData(context, e) {

    var nodeSelected = $(context);
    var projectId = nodeSelected.data('id');
    var action = $("#UploadFile").val();

    bootbox.dialog({
        message: "<form action='" + action + "' class='form-horizontal' method='post' enctype='multipart/form-data' id='infos' action='#'><input value='" + projectId + "' id='projectId' name='projectId' type='hidden'><div>Upload file .scg for [ " + nodeSelected.text() + " ] :</div><br/><input name='file' type='file' class='form-control file'><br/><input value='Upload' type='submit' class='form-control btn btn-primary'></form>",
        title: "",
        buttons: {
            //danger: {
            //    label: "OK",
            //    className: "btn-danger"
            //}
        }
    });

    //bootbox.dialog("<form action" + action + " class='form-horizontal' method='post' enctype='multipart/form-data' id='infos' action='#'><input value='" + projectId + "' id='projectId' name='projectId' type='hidden'><div>Upload file .scg for [ " + nodeSelected.text() + " ] :</div><br/><input name='letter' type='file' class='form-control file'><br/><input value='Upload' type='submit' class='form-control btn btn-primary'></form>");
}


//#endregion
