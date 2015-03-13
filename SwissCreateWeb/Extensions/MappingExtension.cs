using AutoMapper;
using SwissCreate.Core.Domain.Users;
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

        #endregion
    }
}