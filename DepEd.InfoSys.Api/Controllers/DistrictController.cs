﻿using DedEp.InfoSys.Infrastructures.Automapper;
using DepEd.InfoSys.Entities.Models;
using DepEd.InfoSys.Entities.ViewModels.District;
using DepEd.InfoSys.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepEd.InfoSys.Api.Controllers
{
    [Route("api/[controller]")]
    public class DistrictController : Controller
    {
        private readonly IDistrictService service;

        public DistrictController(IDistrictService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.Get(id));
        }

        [HttpPost]
        public void Post([FromBody] DistrictCreateViewModel value)
        {
            service.Add(value.Map<DistrictModel>());
        }

        [HttpPost("{id}")]
        public void Post(int id, [FromBody]DistrictUpdateViewModel value)
        {
            service.Update(value.Map<DistrictModel>());
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
