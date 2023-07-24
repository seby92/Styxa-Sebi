﻿using AutoMapper;
using CityInfo.Entities;
using CityInfo.Models;

namespace CityInfo.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityDto>()
              .ForMember(dest => dest.PoiNumber, opt => opt.MapFrom(src => src.Population));
            CreateMap<CityDto, City>();
        }
    }
}
