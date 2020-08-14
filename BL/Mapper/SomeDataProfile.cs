using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BL.Dto;
using Data.Entities;

namespace BL.Mapper
{
    public class SomeDataProfile : Profile
    {
        public SomeDataProfile()
        {
            CreateMap<SomeDataDto, SomeData>().ReverseMap();
            CreateMap<SomeDataUpdateDto, SomeData>().ReverseMap();
            CreateMap<SomeDataAddDto, SomeData>().ReverseMap();
        }
    }
}
