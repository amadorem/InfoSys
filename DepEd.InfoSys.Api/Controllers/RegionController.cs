using DepEd.InfoSys.Entities.ViewModels.Region;
using DepEd.InfoSys.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DepEd.InfoSys.Entities.Models;
using DedEp.InfoSys.Infrastructures.Automapper;

namespace DepEd.InfoSys.Api.Controllers
{
    [Route("api/[controller]")]
    public class RegionController : Controller
    {
        private readonly IRegionService regionService;

        public RegionController(IRegionService regionService)
        {
            this.regionService = regionService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(regionService.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(regionService.Get(id));
        }

        [HttpPost]
        public void Post([FromBody] RegionCreateViewModel value)
        {
            regionService.Add(value.Map<RegionModel>());
        }

        [HttpPost("{id}")]
        public void Post(int id, [FromBody]RegionUpdateViewModel value)
        {
            regionService.Update(value.Map<RegionModel>());
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {        
            regionService.Delete(id);
        }
    }
}
