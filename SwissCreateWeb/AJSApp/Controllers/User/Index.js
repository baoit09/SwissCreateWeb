jQuery(document).ready(function ($) {
    $(window).bind('beforeunload', function () {
        if (hasBeenChanged) {
            return 'You have made some changes on this list of Users. Do you want to leave these changes?';            
        }
    });

    // show Risks on grid
    setupJsGrids();  

});

var minTempId = 90000;
var tempId = minTempId;
var hasBeenChanged = false;

function setupJsGrids() {

    var MyButtonField = function (config) {
        jsGrid.Field.call(this, config);
    };

    MyButtonField.prototype = new jsGrid.Field({
        //css: "date-field",            // redefine general property 'css'
        align: "center",              // redefine general property 'align'
        itemTemplate: function (userId) {
            return "<button data-userId=" + userId + " type='button' class='btn btn-default' onclick='doGenerateUserPassword(this)' title='Press to generate new password' height='25' width='25'>"
            + 'genereate' + "</button>";
        },
        insertTemplate: function (userId) {
            return "<button data-userId=" + userId + " type='button' class='btn btn-default' onclick='doGenerateUserPassword(this)' title='Press to generate new password' height='25' width='25'>"
           + 'genereate' + "</button>";
        }
    });

    jsGrid.fields.button = MyButtonField;

    $("#jsGrid_Users").jsGrid({
        height: "auto",
        width: "100%",
        filtering: true,
        editing: true,
        sorting: true,
        paging: true,
        autoload: true,

        pageSize: 10,
        pageButtonCount: 5,

        deleteConfirm: "Do you really want to delete this User?",

        controller: {
            loadData: function (filter) {
                return $.grep(window.db.userManagementModel.UserItemModels, function (userItem) {
                    return (!filter.FirstName || !userItem.FirstName || userItem.FirstName.indexOf(filter.FirstName) > -1)
                        && (!filter.MiddleName || !userItem.MiddleName || userItem.MiddleName.indexOf(filter.MiddleName) > -1)
                        && (!filter.Surname || !userItem.Surname || userItem.Surname.indexOf(filter.Surname) > -1)
                        && (!filter.Email || !userItem.Email || userItem.Email.indexOf(filter.Email) > -1)
                        && (!filter.Mobile || !userItem.Mobile || userItem.Mobile.indexOf(filter.Mobile) > -1)
                        && (!filter.Active || userItem.Active === filter.Active)
                        && (!filter.AccountType || userItem.AccountType === filter.AccountType)
                        && (!filter.Username || !userItem.Username || userItem.Username.indexOf(filter.Username) > -1);
                });
            },

            insertItem: function (insertingClient) {
                window.db.userManagementModel.UserItemModels.push(insertingClient);
            },

            updateItem: function (updatingClient) { },

            deleteItem: function (deletingClient) {
                var clientIndex = $.inArray(deletingClient, window.db.userManagementModel.UserItemModels);
                window.db.userManagementModel.UserItemModels.splice(clientIndex, 1);
            }
        },

        fields: [
            { name: "FirstName", type: "text", title: "First Name", width: 70 },
            { name: "MiddleName", type: "text", title: "Middle Name", width: 70 },
            { name: "Surname", type: "text", title: "Surname", width: 70 },
            { name: "Email", type: "text", title: "Email", width: 150 },
            { name: "Mobile", type: "text", title: "Mobile", width: 70 },
            { name: "Active", type: "checkbox", title: "Active", width: 50 },

            { name: "AccountType", type: "select", title: "Account Type", items: window.db.userManagementModel.UserRoleModels, valueField: "Id", textField: "Name" },

            { name: "Username", type: "text", title: "Username", width: 70 },
            { name: "Id", type: "button", title: "Password", width: 70 },

            { type: "control" }
        ],

        onItemInserting: function (args) {
            args.item.Id = ++tempId;
        },

        onItemDeleted: function (args) {
            hasBeenChanged = true;
        },

        onItemInserted: function (args) {
            hasBeenChanged = true;
        },

        onItemUpdated: function (args) {
            hasBeenChanged = true;
        },
    });
}

function doSaveUsers() {
    var postUrl = $("#UpdateUserManagementModel").val();
    var JSONDataString = JSON.stringify(window.db.userManagementModel);
    $.ajax({
        url: postUrl,
        type: "POST",
        contentType: "application/json",
        data: JSONDataString,
        success: function (ResponseResult) {
            if (ResponseResult.success == true) {
                bootbox.alert("Users saved successfully!", function () { });
                hasBeenChanged = false;
            }
            else {
                bootbox.dialog({
                    message: "Users saved failed",
                    title: "Users saved",
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

function getUserManagementModel() {
    var postUrl = $("#GetUserManagementModel").val();
    $.ajax({
        url: postUrl,
        type: "POST",
        success: function (ResponseResult) {
            window.db.userManagementModel = ResponseResult;
            reloadGrid();
        },
        error: function (xhr, ajaxOptions, thrownError) {
            bootbox.dialog({
                message: thrownError,
                title: "Get List User.",
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

function reloadGrid() {
    $("#jsGrid_Users").jsGrid("loadData");
}

function doGenerateUserPassword(element) {
    var userId = parseInt($(element).attr("data-userId"));
    if (userId < 1 || userId === NaN) {
        bootbox.dialog({ message: "User must be inserted first.", title: "Generate user password", buttons: { danger: { label: "OK", className: "btn-danger" } } });
        return;
    }

    // find current user
    var currentUser = getFirstUserModelItemById(userId)

    if (currentUser === undefined || currentUser === null) {
        bootbox.dialog({ message: "User must be inserted first.", title: "Generate user password", buttons: { danger: { label: "OK", className: "btn-danger" } } });
        return;
    }

    // confirm if this user already has password
    if (currentUser.HasPassword) {
        var confirmMsg = "User [ " + currentUser.FirstName + " ] already has password.<br/>Are you sure you want to re-genreate new password?"       
    }

    if (!isValidData(currentUser, "Generate User Password"))
        return;

    var postUrl = $("#GenerateUserPassword").val();
    var postedUser = $.extend({}, currentUser);
    if (postedUser.Id > minTempId)
        postedUser.Id = null;

    var JSONDataString = JSON.stringify(postedUser);
    $.ajax({
        url: postUrl,
        type: "POST",
        contentType: "application/json",
        data: JSONDataString,
        success: function (ResponseResult) {
            if (ResponseResult.success == true) {

                bootbox.alert("The password of User [ " + ResponseResult.updatedUserModelItem.FirstName + " ] has been generated and <br/> an notification email has been sent to [ " + ResponseResult.updatedUserModelItem.Email + " ] successfully!", function () { });

                updateAUserModelItem(ResponseResult.updatedUserModelItem, currentUser)

                if (ResponseResult.isRefreshData) {
                    getUserManagementModel();
                }
            }
            else {
                bootbox.dialog({
                    message: ResponseResult.errorMsg,
                    title: "User Password generated faild",
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

function updateAUserModelItem(updatedUserModelItem, oldUserModelItem) {
    $.extend(oldUserModelItem, updatedUserModelItem);
    $("#jsGrid_Users").jsGrid("updateItem", oldUserModelItem);
}

function getFirstUserModelItemById(Id) {
    var currentUser = $.grep(window.db.userManagementModel.UserItemModels, function (uim) {
        return uim.Id === Id;
    })[0];

    return currentUser;
}

function isValidData(user, title) {

    // check FirstName
    if (user.FirstName === null || user.FirstName === '' || $.trim(user.FirstName) === '') {
        bootbox.dialog({ message: "Firstname must not be empty.", title: title, buttons: { danger: { label: "OK", className: "btn-danger" } } });
        return false;
    }

    // check Username
    if (user.Username === null || user.Username === '' || $.trim(user.Username) === '') {
        bootbox.dialog({ message: "Username of User [ " + user.FirstName + " ] must not be empty.", title: title, buttons: { danger: { label: "OK", className: "btn-danger" } } });
        return false;
    }
    var thesameUNUsers = $.grep(window.db.userManagementModel.UserItemModels, function (uim) {
        return uim.Username === user.Username;
    });
    if (thesameUNUsers.length > 1) {
        bootbox.dialog({ message: "Username [ " + user.Username + " ] of User [ " + user.FirstName + " ] must be unique.", title: title, buttons: { danger: { label: "OK", className: "btn-danger" } } });
        return false;
    }

    // check Email
    if (user.Email === null || user.Email === '' || $.trim(user.Email) === '') {
        bootbox.dialog({ message: "Email of User [ " + user.FirstName + " ] must not be empty.", title: title, buttons: { danger: { label: "OK", className: "btn-danger" } } });
        return false;
    }
    if (!isValidEmailAddress(user.Email)) {
        bootbox.dialog({ message: "Email [ " + user.Email + " ] of User [ " + user.FirstName + " ] must be a valid email.", title: title, buttons: { danger: { label: "OK", className: "btn-danger" } } });
        return false;
    }

    return true;
}

function isValidEmailAddress(emailAddress) {
    var pattern = new RegExp(/^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$/i);
    return pattern.test(emailAddress);
};