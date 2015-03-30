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
		switch (id)
		{
			case "a_folder_addChildFolder" :
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

function folder_AddChildFolder(context, e)
{
	var nodeSelected = $(context);
	var parentCateId = nodeSelected.data('id');

	bootbox.prompt("Enter child folder name for folder [" + nodeSelected[0].innerText + " ] :", function (result) {
		if (result === null) {}
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

						window.location.href = '/Project/FileManager';
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

	bootbox.prompt("Enter file name for folder [" + nodeSelected[0].innerText + " ] :", function (result) {
		if (result === null) { }
		else
		{ // Post data to server
			var url = $("#AddProject").val();
			$.post(url, { "parentCategoryId": parentCateId, "childFileName": result },
				function (ResponseResult) {
					if (ResponseResult.success == true) {
						//bootbox.dialog({
						//	message: "File [" + result + "] has been added.",
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

function folder_DeleteFolder(context, e) {
	var nodeSelected = $(context);
	var parentCateId = nodeSelected.data('id');

	bootbox.confirm("Are you sure you want to delete folder [" + nodeSelected[0].innerText + "] ?", function (result) {
		if (result == true)
		{
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
							message: "Folder [" + nodeSelected[0].innerText + "] failed to delete. Folder should be empty.",
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
		title: "Enter new folder name for folder [ " + nodeSelected[0].innerText + " ] : ",
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
								message: "Change name of folder [" + nodeSelected[0].innerText + "] failed. The new folder name must differ with the old name",
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

	bootbox.confirm("Are you sure you want to delete file [" + nodeSelected[0].innerText + "] ?", function (result) {
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
							message: "File [" + nodeSelected[0].innerText + "] failed to delete.",
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
		title: "Enter new file name for file [" + nodeSelected[0].innerText + "] :",
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
								message: "Change name of file [" + nodeSelected[0].innerText + "] failed.",
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

//#endregion
