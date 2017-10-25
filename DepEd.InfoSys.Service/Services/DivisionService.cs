using DepEd.InfoSys.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DepEd.InfoSys.Entities.Models;
using DepEd.InfoSys.Entities.Entities;
using DepEd.InfoSys.Data.Interfaces;
using DepEd.InfoSys.Entities;
using System.Linq;
using DedEp.InfoSys.Infrastructures.Automapper;

namespace DepEd.InfoSys.Service.Services
{
    public class DivisionService : IDivisionService
    {
        private readonly IRepository<Division> repository;

        public DivisionService(IRepository<Division> repository)
        {
            this.repository = repository;
        }

        public void Add(DivisionModel model)
        {
            // TODO: Validation

            repository.Add(model
                .Map<Division>());

            repository.Save();
        }

        public void Delete(int id)
        {
            // TODO: Validation

            var model = repository.Get(id);

            repository.Delete(model);

            repository.Save();
        }

        public DivisionModel Get(int id)
        {
            return repository.Get(id)
                .Map<DivisionModel>();
        }

        public IEnumerable<DivisionModel> Get()
        {
            return repository.Get()
                .AsEnumerable()
                .Map<DivisionModel>();
        }

        public void Update(DivisionModel model)
        {
            // TODO: Validation
            repository.Update(model.Map<Division>());

            repository.Save();
        }
    }
}
