using AutoMapper;
using DedEp.InfoSys.Infrastructures.Automapper.Profiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace DedEp.InfoSys.Infrastructures.Automapper
{
    public static class Configuration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new RegionProfile());
                cfg.AddProfile(new DivisionProfile());
            });
        }

    }
}
