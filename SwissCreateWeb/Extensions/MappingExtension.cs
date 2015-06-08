using AutoMapper;
using SwissCreate.Core.Domain.Projects;
using SwissCreate.Core.Domain.Users;
using SwissCreateWeb.Models.Project;
using SwissCreateWeb.Models.User;

namespace SwissCreateWeb.Extensions
{
    public static class MappingExtension
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return Mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return Mapper.Map(source, destination);
        }

        #region User

        public static UserProfileModel ToModel(this User entity)
        {
            return entity.MapTo<User, UserProfileModel>();
        }

        public static User ToEntity(this UserProfileModel entity)
        {
            return entity.MapTo<UserProfileModel, User>();
        }

        public static UserItemModel ToUserItemModel(this User entity)
        {
            return entity.MapTo<User, UserItemModel>();
        }

        public static User ToEntity2(this UserItemModel entity)
        {
            return entity.MapTo<UserItemModel, User>();
        }

        #endregion

        #region UserRole

        public static UserRoleModel ToModel(this UserRole entity)
        {
            return entity.MapTo<UserRole, UserRoleModel>();
        }

        public static UserRole ToEntity(this UserRoleModel entity)
        {
            return entity.MapTo<UserRoleModel, UserRole>();
        }

        #endregion

        #region Project

        public static ProjectModel ToModel(this Project entity)
        {
            return entity.MapTo<Project, ProjectModel>();
        }

        public static Project ToEntity(this ProjectModel entity)
        {
            return entity.MapTo<ProjectModel, Project>();
        }

        #endregion

        #region Project Category

        public static ProjectCategoryModel ToModel(this ProjectCategory entity)
        {
            return entity.MapTo<ProjectCategory, ProjectCategoryModel>();
        }

        public static ProjectCategory ToEntity(this ProjectCategoryModel entity)
        {
            return entity.MapTo<ProjectCategoryModel, ProjectCategory>();
        }

        #endregion
    }
}