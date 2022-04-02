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
    [Route("TypyDan")]
    [ApiController]
    public class KartaDanController : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly IKartaDan kartaDan;

        public KartaDanController(IMapper mapper, BLKartaDan kartaDan)
        {
            this.mapper = mapper;
            this.kartaDan = kartaDan;
        }


        // GET: Zamowienie/5

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
