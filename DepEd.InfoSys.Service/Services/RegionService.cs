using DepEd.InfoSys.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DepEd.InfoSys.Data.Interfaces;
using System.Linq;

using DepEd.InfoSys.Entities;
using DepEd.InfoSys.Entities.Models;
using DepEd.InfoSys.AutoMapper;

namespace DepEd.InfoSys.Service.Services
{
    public class RegionService : IRegionService
    {
        private readonly IRepository<Region> repository;

        public RegionService(IRepository<Region> repository)
        {
            this.repository = repository;
        }

        public void Add(RegionModel regionModel)
        {
            // TODO: Validation

            repository.Add(regionModel
                .Map<Region>());

            repository.Save();
        }

        public void Delete(int id)
        {
            // TODO: Validation

            var region = repository.Get(id);

            repository.Delete(region);

            repository.Save();

        }

        public void Update(RegionModel regionModel)
        {
            // TODO: Validation
            repository.Update(regionModel.Map<Region>());

            repository.Save();
        }

        public RegionModel Get(int id)
        {
            return repository.Get(id)
                .Map<RegionModel>();
        }

        public IEnumerable<RegionModel> Get()
        {
            return repository.Get()
                .AsEnumerable()
                .Map<RegionModel>();
        }
    }
}
