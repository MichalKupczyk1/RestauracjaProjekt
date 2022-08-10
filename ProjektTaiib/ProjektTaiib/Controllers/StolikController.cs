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
    [Route("Rezerwacja")]
    [ApiController]
    public class StolikController : Controller
    {

        private readonly IMapper mapper;
        private readonly IStolik blStolik;
        StolikiMS mS;
        public StolikController(IMapper mapper, BLStolik stolik)
        {
            this.mapper = mapper;
            this.blStolik = stolik;


        }


        [HttpGet]
        public async Task<IActionResult> Index([FromQuery(Name = "idt")] int? id, [FromQuery(Name = "idIleMiejsc")] int? idIleMiejsc)
        {
            mS = new StolikiMS();
            mS.ZaznaczonyId = Convert.ToInt32(id);
            blStolik.zajmowanieIStolik(Convert.ToInt32(id));
          
            if (idIleMiejsc != null )
            {
                mS.PodanaIloscMiejsc = (int)idIleMiejsc;
                mS.Stoliki = blStolik.getStoliki().Where(i => i.ileMiejsc >= idIleMiejsc).ToList();
            }else {
                mS.Stoliki = blStolik.getStoliki().ToList();
            }
           
            mS.iloscWolnychStolikow = (int)blStolik.getStoliki().Where(i => !i.czyZajety).Count();

            return View(mS);
        }
        public async Task<IActionResult> ZajmowanieCont(int id)
        {

            //blStolik.zajmowanieIStolik(id);
            return View();
        }
        public IEnumerable<StolikBasic> Get()
        {
            var stolik = blStolik.getStoliki();
            return mapper.Map<IEnumerable<Stolik>, IEnumerable<StolikBasic>>(stolik);
        }

        // GET: Stolik/5
        // [HttpGet("{stolikId}")]
        public StolikBasic Get(int stolikId)
        {
            blStolik.zajmowanieIStolik(stolikId);
            mS.ZaznaczonyId = stolikId;
            var stolik = blStolik.getStolik(stolikId);
            return mapper.Map<Stolik, StolikBasic>(stolik);
        }
        [HttpGet("{asdad}")]
        public async Task<IActionResult> Inde2x(int? idt)
        {
            mS = new StolikiMS();
            blStolik.zajmowanieIStolik(Convert.ToInt32(idt));
            mS.Stoliki = blStolik.getStoliki().ToList();
            mS.ZaznaczonyId = Convert.ToInt32(idt);
       
            mS.iloscWolnychStolikow = (int)blStolik.getStoliki().Where(i => !i.czyZajety).Count();

            return View();
        }

        // POST: api/Stolik

        [HttpPost]
        public async Task<IActionResult> Index2([FromQuery(Name = "idt")] int idt)
        {
            mS = new StolikiMS();
         
            blStolik.zajmowanieIStolik(Convert.ToInt32(idt));
            mS.Stoliki = blStolik.getStoliki().ToList();
              mS.ZaznaczonyId = Convert.ToInt32(idt);
            
            mS.iloscWolnychStolikow = (int)blStolik.getStoliki().Where(i => !i.czyZajety).Count();

            return View();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public void Delete(int stolikId)
        {
        }
    }
}
