using APARTMENTS.Dtos;
using APARTMENTS.DtosPhoto;
using APARTMENTS.Extensions;
using APARTMENTS.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Helpers
{ 
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles() {
            CreateMap<User, RegisterDTO>();
            CreateMap<RegisterDTO,User > ();
            //Kalkuliranje Datuma rodjenja za korisnika
            CreateMap<User, MemberDto>().ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Adress, GetAdressDto>();
            CreateMap<MemberDto, User>();
            CreateMap<Apartment, GetApartmentDto>();
            CreateMap<Photo, PhotoDto>();
            CreateMap<PhotoDto, Photo>();
        }
    }
}
