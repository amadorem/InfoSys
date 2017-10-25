using DepEd.InfoSys.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DepEd.InfoSys.Entities.Models;
using DepEd.InfoSys.Data.Interfaces;
using DepEd.InfoSys.Entities.Entities;
using DedEp.InfoSys.Infrastructures.Automapper;
using System.Linq;

namespace DepEd.InfoSys.Service.Services
{
    public class DistrictService : IDistrictService
    {
        private readonly IRepository<District> repository;

        public DistrictService(IRepository<District> repository)
        {
            this.repository = repository;
        }

        public void Add(DistrictModel model)
        {
            // TODO: Validation

            repository.Add(model
                .Map<District>());

            repository.Save();
        }

        public void Delete(int id)
        {
            // TODO: Validation

            var model = repository.Get(id);

            repository.Delete(model);

            repository.Save();
        }

        public DistrictModel Get(int id)
        {
            return repository.Get(id)
                .Map<DistrictModel>();
        }

        public IEnumerable<DistrictModel> Get()
        {
            return repository.Get()
                .AsEnumerable()
                .Map<DistrictModel>();
        }

        public void Update(DistrictModel model)
        {
            // TODO: Validation
            repository.Update(model.Map<District>());

            repository.Save();
        }
    }
}
