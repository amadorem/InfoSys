using AutoMapper;
using DepEd.InfoSys.Entities;
using DepEd.InfoSys.Entities.Models;
using DepEd.InfoSys.Entities.ViewModels.Region;

namespace DepEd.InfoSys.AutoMapper.Profiles
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
