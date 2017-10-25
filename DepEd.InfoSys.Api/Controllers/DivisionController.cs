using DedEp.InfoSys.Infrastructures.Automapper;
using DepEd.InfoSys.Entities.Models;
using DepEd.InfoSys.Entities.ViewModels.Division;
using DepEd.InfoSys.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepEd.InfoSys.Api.Controllers
{
    [Route("api/[controller]")]
    public class DivisionController : Controller
    {
        private readonly IDivisionService service;

        public DivisionController(IDivisionService service)
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
        public void Post([FromBody] DivisionCreateViewModel value)
        {
            service.Add(value.Map<DivisionModel>());
        }

        [HttpPost("{id}")]
        public void Post(int id, [FromBody]DivisionUpdateViewModel value)
        {
            service.Update(value.Map<DivisionModel>());
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
