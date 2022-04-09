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
    [Route("KartaDan")]
    [ApiController]
    public class KartaDanController : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly IKartaDan BLKartaDan;

        public KartaDanController(IMapper mapper, BLKartaDan kartaDan)
        {
            this.mapper = mapper;
            this.BLKartaDan = kartaDan;
        }


        [HttpGet]
        public IEnumerable<KartaDanBasic> Get()
        {
            var kartaDan = BLKartaDan.GetKartyDan();
            return mapper.Map<IEnumerable<KartaDan>, IEnumerable<KartaDanBasic>>(kartaDan);
            /* 
             *  mapperuje z Zamowienie do zamowienieTest 
             */
        }
        // GET: KartaDan/5
        [HttpGet("{kartaDanId}")]
        public KartaDanBasic Get(int kartaDanId)
        {
                var kartaDan = BLKartaDan.getKartaDan(kartaDanId);
                return mapper.Map<KartaDan, KartaDanBasic>(kartaDan);
           
        }


        // POST: api/KartaDan
        [HttpPost]
        public void Post([FromBody] KartaDan kartaDanId)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{kartaDanId}")]
        public void Delete(int kartaDanId)
        {
        }
    }
}
