using AutoMapper;
using DepEd.InfoSys.Entities.Entities;
using DepEd.InfoSys.Entities.Models;
using DepEd.InfoSys.Entities.ViewModels.District;
using System;
using System.Collections.Generic;
using System.Text;

namespace DedEp.InfoSys.Infrastructures.Automapper.Profiles
{
    public class DistrictProfile : Profile
    {
        public DistrictProfile()
        {
            CreateMap<District, DistrictModel>()
                .ReverseMap();

            CreateMap<DistrictModel, DistrictCreateViewModel>()
                    .ReverseMap();

            CreateMap<DistrictModel, DistrictUpdateViewModel>()
                    .ReverseMap();

            CreateMap<DistrictModel, DistrictItemViewModel>()
                    .ReverseMap();
        }
    }
}
