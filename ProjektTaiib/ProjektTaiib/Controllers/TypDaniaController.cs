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
    [Route("TypDania")]
    [ApiController]
    public class TypDaniaController : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly ITypDania blTypDania;

        public TypDaniaController(IMapper mapper, BLTypDania typDania)
        {
            this.mapper = mapper;
            this.blTypDania = typDania;
        }


        [HttpGet]
        public IEnumerable<TypDaniaBasic> Get()
        {
            var TypDania = blTypDania.getTypyDania();
            return mapper.Map<IEnumerable<TypDania>, IEnumerable<TypDaniaBasic>>(TypDania);
        }
       
        [HttpGet("{typDaniaId}")]
        public TypDaniaBasic Get(int typDaniaId)
        {
            var typDania = blTypDania.getTypDania(typDaniaId);
            return mapper.Map<TypDania,TypDaniaBasic>(typDania);
        }

        // POST: api/TypDania
        [HttpPost]
        public void Post([FromBody] TypDania typDania)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{typDaniaId}")]
        public void Delete(int typDaniaId)
        {
        }
    }
}
