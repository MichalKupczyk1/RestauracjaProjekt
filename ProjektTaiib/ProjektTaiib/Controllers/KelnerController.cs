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
    [Route("Kelner")]
    [ApiController]
    public class KelnerController : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly IKelner blKelner;

        public KelnerController(IMapper mapper, BLKelner kelner)
        {
            this.mapper = mapper;
            this.blKelner = kelner;
        }


        // GET: Kelner
        [HttpGet]
        public IEnumerable<KelnerBasic> Get()
        {
            var kelnerzy = blKelner.getKelnerzy();
            return mapper.Map<IEnumerable<Kelner>, IEnumerable<KelnerBasic>>(kelnerzy);
            /* 
             *  mapperuje z Zamowienie do zamowienieTest 
             */
        }
        // GET: Kelner/5
        [HttpGet("{kelnerId}")]
        public KelnerBasic Get(int kelnerId)
        {
             var kelnerzy = blKelner.getKelner(kelnerId);
            return mapper.Map<Kelner, KelnerBasic>(kelnerzy);

            // var kelnerzy = blKelner.getZamowieniaKelnera(kelnerId);
            //return mapper.Map<IEnumerable<Zamowienie>, IEnumerable<ZamowienieBasic>>(kelnerzy);
        }

        // POST: api/Kelner
        [HttpPost]
        public void Post([FromBody] Kelner kelner)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{kelnerId}")]
        public void Delete(int kelnerId)
        {
        }
    }

}