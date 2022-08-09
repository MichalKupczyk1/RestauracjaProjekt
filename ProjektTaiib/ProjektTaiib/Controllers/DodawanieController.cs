using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjektTaiib.Interfaces;
using ProjektTaiib.ViewModels;

namespace ProjektTaiib.Controllers
{
    [Route("Dodawanie")]
    [ApiController]
    public class DodawanieController : Controller
    {
        private readonly IMapper mapper;
        private readonly IStolik blStolik;
        private readonly IKartaDan blkartaDan;
        private readonly IKelner blKelner;
        private readonly ITypDania blTypDania;
        private readonly IZamowienie blZamowienie;
        DodajMS dM;
        public DodawanieController(IMapper mapper, BLStolik stolik,BLKartaDan kartaDan, BLKelner kelner,BLTypDania typDania,BLZamowienie zamowienie)
        {
            this.mapper = mapper;
            this.blStolik = stolik;
            this.blkartaDan = kartaDan;
            this.blKelner = kelner;
            this.blTypDania = typDania;
            this.blZamowienie = zamowienie;


        }
        [HttpGet]
        public async Task<IActionResult> Index(
            [FromQuery(Name = "idS")] int? idS,
            [FromQuery(Name = "idK")] int? idK, 
            [FromQuery(Name = "idD")] int? idD,
            [FromQuery(Name = "idDel")] int? idDel)
        {

            if (idDel != null)
            {
                blZamowienie.deleteZamowienie((int)idDel);
            }

            dM = new DodajMS();
            dM.aaa += "1";
            if (idS != null && idK != null && idD != null) {
                blZamowienie.addZamowienie(new Models.Zamowienie() { id_stolik = (int)idS, id_kelner = (int)idK, id_kartaDan = (int)idD });
                dM.aaa += "2";
            }

            dM.aaa += "3";


            dM.dodajZs = new List<DodajZ>();
            dM.KartyDan = blkartaDan.GetKartyDan().ToList();
            dM.Kelnerzy = blKelner.getKelnerzy().ToList();
            
            blZamowienie.getZamowienia().ToList().ForEach(i =>
            {
                dM.dodajZs.Add(new DodajZ()
                {
                    id = i.id_stolik,
                    nazwa = blkartaDan.GetKartyDan().FirstOrDefault(e => e.id == i.id_kartaDan).nazwaDania,
                    rodzajDania = blTypDania.getTypyDania().FirstOrDefault(e => e.id == blkartaDan.GetKartyDan().FirstOrDefault(e => e.id == i.id_kartaDan).id_typDania).nazwaTypu,
                    cena = blkartaDan.GetKartyDan().FirstOrDefault(e => e.id == i.id_kartaDan).cena,
                    imie = blKelner.getKelnerzy().FirstOrDefault(e => e.id == i.id_kartaDan).imie + " " + blKelner.getKelnerzy().FirstOrDefault(e => e.id == i.id_kartaDan).nazwisko,
                    id_zamowienia = i.id
                });
            });
           
            dM.Stoliki = blStolik.getStoliki().ToList();

            
            return View(dM);
        }
        [HttpPost, ActionName("Delete")]
        public RedirectToActionResult Delete([FromQuery(Name = "id")]  int id)
        {


            int i = id;
            blZamowienie.deleteZamowienie(id);
            return RedirectToAction("Index", "Dodawanie");
        }
    }
}
