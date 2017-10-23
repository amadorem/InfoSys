using AutoMapper;
using DepEd.InfoSys.AutoMapper.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.AutoMapper
{
    public static class Configuration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new RegionProfile());
            });
        }

    }
}
