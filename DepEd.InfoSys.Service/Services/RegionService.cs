﻿using DepEd.InfoSys.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DepEd.InfoSys.Data.Interfaces;
using System.Linq;
using DepEd.InfoSys.Entities;
using DepEd.InfoSys.Entities.Models;
using DedEp.InfoSys.Infrastructures.Automapper;

namespace DepEd.InfoSys.Service.Services
{
    public class RegionService : IRegionService
    {
        private readonly IRepository<Region> repository;

        public RegionService(IRepository<Region> repository)
        {
            this.repository = repository;
        }

        public void Add(RegionModel model)
        {
            // TODO: Validation

            repository.Add(model
                .Map<Region>());

            repository.Save();
        }

        public void Delete(int id)
        {
            // TODO: Validation

            var model = repository.Get(id);

            repository.Delete(model);

            repository.Save();

        }

        public void Update(RegionModel model)
        {
            // TODO: Validation
            repository.Update(model.Map<Region>());

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
