using FluentValidation.Attributes;
using SwissCreateWeb.Framework;
using SwissCreateWeb.Framework.Mvc;
using SwissCreateWeb.Validators.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Models.User
{
    [Validator(typeof(UserProfileValidator))]
    public class UserProfileModel : BaseSwissCreateModel
    {
        [SwissCreateResourceDisplayName("Account.UserProfile.Fields.FirstName")]
        public string FirstName { get; set; }

        [SwissCreateResourceDisplayName("Account.UserProfile.Fields.MiddleName")]
        public string MiddleName { get; set; }

        [SwissCreateResourceDisplayName("Account.UserProfile.Fields.Surname")]
        public string Surname { get; set; }

        [SwissCreateResourceDisplayName("Account.UserProfile.Fields.Email")]
        public string Email { get; set; }

        [SwissCreateResourceDisplayName("Account.UserProfile.Fields.Mobile")]
        public string Mobile { get; set; }

        [SwissCreateResourceDisplayName("Account.UserProfile.Fields.Username")]
        public string Username { get; set; }

        public string Result { get; set; }
    }
}