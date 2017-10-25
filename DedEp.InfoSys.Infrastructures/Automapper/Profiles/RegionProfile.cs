using AutoMapper;
using DepEd.InfoSys.Entities;
using DepEd.InfoSys.Entities.Models;
using DepEd.InfoSys.Entities.ViewModels.Region;
using System;
using System.Collections.Generic;
using System.Text;

namespace DedEp.InfoSys.Infrastructures.Automapper.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Region, RegionModel>()
                .ReverseMap();

            CreateMap<RegionModel, RegionCreateViewModel>()
                .ReverseMap();

            CreateMap<RegionModel, RegionUpdateViewModel>()
                .ReverseMap();

            CreateMap<RegionModel, RegionItemViewModel>()
                .ReverseMap();
        }
    }
}
