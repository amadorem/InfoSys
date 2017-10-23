
using DepEd.InfoSys.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.Service.Interfaces
{
    public interface IRegionService
    {
        RegionModel Get(int id);

        IEnumerable<RegionModel> Get();

        void Add(RegionModel regionModel);

        void Update(RegionModel regionModel);

        void Delete(int id);
    }
}
