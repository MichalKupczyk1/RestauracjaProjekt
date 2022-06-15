using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjektTaiib.basic;
using ProjektTaiib.Interfaces;
using ProjektTaiib.Models;
using ProjektTaiib.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjektTaiib.Controllers
{
    [Route("Stolik")]
    [ApiController]
    public class StolikController : Controller
    {

        private readonly IMapper mapper;
        private readonly IStolik blStolik;

        public StolikController(IMapper mapper, BLStolik stolik)
        {
            this.mapper = mapper;
            this.blStolik = stolik;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            StolikiMS mS = new StolikiMS();
            mS.Stoliki = blStolik.getStoliki().ToList();
            mS.ZaznaczonyId = id;
            blStolik.zajmowanieIStolik(id);
            mS.iloscWolnychStolikow = (int)blStolik.getStoliki().Where(i => !i.czyZajety).Count();
            return View(mS);
        }
       public async Task<IActionResult> ZajmowanieCont(int id)
        {
        
            blStolik.zajmowanieIStolik(id);
            return View();
        }
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
