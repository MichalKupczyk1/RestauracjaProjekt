using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjektTaiib.basic;
using ProjektTaiib.Interfaces;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Controllers
{
    [Route("Stolik")]
    [ApiController]
    public class StolikController : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly IStolik blStolik;

        public StolikController(IMapper mapper, BLStolik stolik)
        {
            this.mapper = mapper;
            this.blStolik = stolik;
        }


        [HttpGet]
        public IEnumerable<StolikBasic> Get()
        {
            var stolik = blStolik.getStoliki();
            return mapper.Map<IEnumerable<Stolik>, IEnumerable<StolikBasic>>(stolik);
   
        }
        // GET: Stolik/5
        [HttpGet("{stolikId}")]
        public StolikBasic Get(int stolikId)
        {
            var stolik = blStolik.getStolik(stolikId);
            return mapper.Map<Stolik,StolikBasic>(stolik);
        }

        // POST: api/Stolik
        [HttpPost]
        public void Post([FromBody] Stolik stolik)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{stolikId}")]
        public void Delete(int stolikId)
        {
        }
    }
}
