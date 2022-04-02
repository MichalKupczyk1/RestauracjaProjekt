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
    [Route("Kelnerzy")]
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


        // GET: api/Zamowienie
        [HttpGet]
        public IEnumerable<KelnerBasic> Get()
        {
            var kelnerzy = blKelner.getKelnerzy();
            return mapper.Map<IEnumerable<Kelner>, IEnumerable<KelnerBasic>>(kelnerzy);
            /* 
             *  mapperuje z Zamowienie do zamowienieTest 
             */
        }
        // GET: api/Zamowienie/5
        [HttpGet("{id}")]
        public IEnumerable<ZamowienieBasic> Get(int kelnerId)
        {
            var kelnerzy = blKelner.getZamowieniaKelnera(kelnerId);
            return mapper.Map<IEnumerable<Zamowienie>, IEnumerable<ZamowienieBasic>>(kelnerzy);
        }

        // POST: api/Zamowienie
        [HttpPost]
        public void Post([FromBody] Zamowienie zamowienie)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

}