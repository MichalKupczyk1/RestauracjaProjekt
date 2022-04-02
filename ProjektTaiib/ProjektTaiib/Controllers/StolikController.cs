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
    public class StolikController : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly IStolik stolik;

        public StolikController(IMapper mapper, BLStolik stolik)
        {
            this.mapper = mapper;
            this.stolik = stolik;
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
