using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FluentValidation.Attributes;
using SwissCreateWeb.Framework;
using SwissCreateWeb.Framework.Mvc;
using SwissCreateWeb.Validators.User;

namespace SwissCreateWeb.Models.User
{
    [Validator(typeof(ChangePasswordValidator))]
    public partial class ChangePasswordModel : BaseSwissCreateModel
    {
        [AllowHtml]
        [DataType(DataType.Password)]
        [SwissCreateResourceDisplayName("Account.ChangePassword.Fields.OldPassword")]
        public string OldPassword { get; set; }

        [AllowHtml]
        [DataType(DataType.Password)]
        [SwissCreateResourceDisplayName("Account.ChangePassword.Fields.NewPassword")]
        public string NewPassword { get; set; }

        [AllowHtml]
        [DataType(DataType.Password)]
        [SwissCreateResourceDisplayName("Account.ChangePassword.Fields.ConfirmNewPassword")]
        public string ConfirmNewPassword { get; set; }

        public string Result { get; set; }

    }
}