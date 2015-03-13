using AutoMapper;
using SwissCreate.Core.Domain.Users;
using SwissCreate.Core.Infrastructure;
using SwissCreateWeb.Models;
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
            Mapper.CreateMap<User, UserProfileViewModel>()
            .ForMember(dest => dest.OldPassword, mo => mo.Ignore())
            .ForMember(dest => dest.NewPassword, mo => mo.Ignore())
            .ForMember(dest => dest.NewPassword2, mo => mo.Ignore());
            Mapper.CreateMap<UserProfileViewModel, User>()
            .ForMember(dest => dest.Password, mo => mo.MapFrom(src => src.NewPassword));
            #endregion
        }
        public int Order
        {
            get { return 0; }
        }
    }
}