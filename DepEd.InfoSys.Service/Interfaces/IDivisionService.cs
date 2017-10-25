using DepEd.InfoSys.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.Service.Interfaces
{
    public interface IDivisionService
    {
        DivisionModel Get(int id);

        IEnumerable<DivisionModel> Get();

        void Add(DivisionModel model);

        void Update(DivisionModel model);

        void Delete(int id);
    }
}
