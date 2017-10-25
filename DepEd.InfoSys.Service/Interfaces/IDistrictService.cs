using DepEd.InfoSys.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.Service.Interfaces
{
    public interface IDistrictService
    {
        DistrictModel Get(int id);

        IEnumerable<DistrictModel> Get();

        void Add(DistrictModel model);

        void Update(DistrictModel model);

        void Delete(int id);
    }
}
