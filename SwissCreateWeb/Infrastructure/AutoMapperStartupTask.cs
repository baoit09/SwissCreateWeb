using AutoMapper;
using SwissCreate.Core.Domain.Projects;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Core.Infrastructure;
using SwissCreateWeb.Models;
using SwissCreateWeb.Models.Project;
using SwissCreateWeb.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwissCreateWeb.Infrastructure
{
    public class AutoMapperStartupTask : IStartupTask
    {
        public void Execute()
        {
            #region User Mapping

            Mapper.CreateMap<User, UserProfileModel>();
            Mapper.CreateMap<UserProfileModel, User>();

            Mapper.CreateMap<User, UserItemModel>()
                .ForMember(ui => ui.AccountType, mce => mce.MapFrom(u => GetAccounTypeId(u)))
                .ForMember(ui => ui.HasPassword, mce => mce.MapFrom(u => !string.IsNullOrWhiteSpace(u.Password)));
            Mapper.CreateMap<UserItemModel, User>();

            #endregion

            #region UserRole Mapping

            Mapper.CreateMap<UserRole, UserRoleModel>();
            Mapper.CreateMap<UserRoleModel, UserRole>();

            #endregion

            #region Project Mapping

            Mapper.CreateMap<Project, ProjectModel>();
            Mapper.CreateMap<ProjectModel, Project>();

            #endregion

            #region Project Category Mapping

            Mapper.CreateMap<ProjectCategory, ProjectCategoryModel>();
            Mapper.CreateMap<ProjectCategoryModel, ProjectCategory>();

            #endregion
        }
        public static int? GetAccounTypeId(User u)
        {
            var role = u.UserRoles.FirstOrDefault();
            if (role != null)
            {
                return role.Id;
            }
            return (int?)null;
        }
        public int Order
        {
            get { return 0; }
        }
    }
}