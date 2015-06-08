using SwissCreate.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Models.User
{
    public class UserManagementModel
    {
        public List<UserItemModel> UserItemModels { get; set; }
        public List<UserRoleModel> UserRoleModels { get; set; }
    }

    public class UserItemModel : BaseEntity
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public bool Active { get; set; }

        public int? AccountType { get; set; }
        
        public string Username { get; set; }

        public bool HasPassword { get; set; }
    }

    public class UserRoleModel : BaseEntity
    {
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}