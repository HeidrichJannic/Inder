using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataBase;
using Inder.Contracts.User;
//using verweise hinzufügen TODO

namespace Inder.Api.Core.Services
{
    public class MapperService : Profile
    {
        public MapperService()
        {
            CreateMap<UserCreateDTO, UserDTO>()           
            .ForMember(entity => entity.Name, source => source.MapFrom(source => source.Name))
            .ForMember(entity => entity.Surname, source => source.MapFrom(source => source.Surname))
            .ForMember(entity => entity.Age, source => source.MapFrom(source => source.Age))
            .ForMember(entity => entity.Height, source => source.MapFrom(source => source.Height))
            .ForMember(entity => entity.Weight, source => source.MapFrom(source => source.Weight))
            .ForMember(entity => entity.Gender, source => source.MapFrom(source => source.Gender))
            .ForMember(entity => entity.Bio, source => source.MapFrom(source => source.Bio))
            .ForMember(entity => entity.ProfilePicture, source => source.MapFrom(source => source.ProfilePicture));

            CreateMap<UserDTO, UserModel>()
           .ForMember(entity => entity.ID, source => source.MapFrom(source => source.Id))
           .ForMember(entity => entity.Name, source => source.MapFrom(source => source.Name))
           .ForMember(entity => entity.Surname, source => source.MapFrom(source => source.Surname))
           .ForMember(entity => entity.Age, source => source.MapFrom(source => source.Age))
           .ForMember(entity => entity.Height, source => source.MapFrom(source => source.Height))
           .ForMember(entity => entity.Weight, source => source.MapFrom(source => source.Weight))
           .ForMember(entity => entity.Gender, source => source.MapFrom(source => source.Gender))

           .ForMember(entity => entity.Bio, source => source.MapFrom(source => source.Bio))
           .ForMember(entity => entity.ProfilePic, source => source.MapFrom(source => source.ProfilePicture));

           CreateMap<UserModel, UserDTO>()
           .ForMember(entity => entity.Id, source => source.MapFrom(source => source.ID))
           .ForMember(entity => entity.Name, source => source.MapFrom(source => source.Name))
           .ForMember(entity => entity.Surname, source => source.MapFrom(source => source.Surname))
           .ForMember(entity => entity.Age, source => source.MapFrom(source => source.Age))
           .ForMember(entity => entity.Height, source => source.MapFrom(source => source.Height))
           .ForMember(entity => entity.Weight, source => source.MapFrom(source => source.Weight))
           .ForMember(entity => entity.Gender, source => source.MapFrom(source => source.Gender))
           .ForMember(entity => entity.Bio, source => source.MapFrom(source => source.Bio))
           .ForMember(entity => entity.ProfilePicture, source => source.MapFrom(source => source.ProfilePic));


        }
    }
}
