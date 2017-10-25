using AutoMapper;
using DepEd.InfoSys.Entities.Entities;
using DepEd.InfoSys.Entities.Models;
using DepEd.InfoSys.Entities.ViewModels.Division;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.AutoMapper.Profiles
{
    public class DivisionProfile : Profile
    {
        public DivisionProfile()
        {
            CreateMap<Division, DivisionModel>()
                .ReverseMap();

            CreateMap<DivisionModel, DivisionCreateViewModel>()
                .ReverseMap();

            CreateMap<DivisionModel, DivisionUpdateViewModel>()
                .ReverseMap();

            CreateMap<DivisionModel, DivisionItemViewModel>()
                .ReverseMap();
        }
    }
}
