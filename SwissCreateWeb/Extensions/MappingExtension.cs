using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SwissCreate.Core.Domain.Users;
using SwissCreateWeb.Models;

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

        public static UserProfileViewModel ToViewModel(this User entity)
        {
            return entity.MapTo<User, UserProfileViewModel>();
        }

        public static User ToEntity(this UserProfileViewModel entity)
        {
            return entity.MapTo<UserProfileViewModel, User>();
        }

        #endregion
    }
}