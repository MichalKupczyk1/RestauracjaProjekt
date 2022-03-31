using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjektTaiib.Interfaces;
using ProjektTaiib.Models;


namespace ProjektTaiib.Controllers
{
    [Route("api/Zamowienie")]
    [ApiController]
   

    public class ZamowienieController:ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IZamowienie blZamowienie;
        
        public ZamowienieController(IMapper mapper,IZamowienie zamowienie)
        {
            this.mapper = mapper;
            this.blZamowienie = zamowienie;
        }


        // GET: api/Zamowienie
        [HttpGet]
        public IEnumerable<Zamowienie> Get()
        {
            var zamowienia = blZamowienie.getZamowienia();
            return mapper.Map<IEnumerable<Zamowienie>, IEnumerable<Zamowienie>>(zamowienia);
        }
        // GET: api/Zamowienie/5
        [HttpGet("{id}")]
        public IEnumerable<Zamowienie> Get(int ZamowienieId)
        {
            var zamowienia = blZamowienie.getZamowienia();
            return mapper.Map<IEnumerable<Zamowienie>, IEnumerable<Zamowienie>>(zamowienia);
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