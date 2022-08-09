using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjektTaiib.Interfaces;
using ProjektTaiib.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Controllers
{
    [Route("Placenie")]
    [ApiController]
    public class PlacenieController : Controller
    {
        private readonly IMapper mapper;
        private readonly IStolik blStolik;
        private readonly IKartaDan blkartaDan;
        private readonly IKelner blKelner;
        private readonly ITypDania blTypDania;
        private readonly IZamowienie blZamowienie;
        PlacenieMS placenieMS;
        public PlacenieController(IMapper mapper, BLStolik stolik, BLKartaDan kartaDan, BLKelner kelner, BLTypDania typDania, BLZamowienie zamowienie)
        {
            this.mapper = mapper;
            this.blStolik = stolik;
            this.blkartaDan = kartaDan;
            this.blKelner = kelner;
            this.blTypDania = typDania;
            this.blZamowienie = zamowienie;


        }
        
       [HttpGet]
        public async Task<IActionResult> Index([FromQuery(Name = "IdStolika")] int? idZamowienia, [FromQuery(Name = "IdUsuwanie")] int? IdUsuwanie)
        {
            if (IdUsuwanie != null) {
                blZamowienie.getZamowienia().Where(i => i.id_stolik == IdUsuwanie).ToList().ForEach(zamowienie => {
                    blZamowienie.deleteZamowienie(zamowienie.id);
                    });
            }
            placenieMS = new PlacenieMS();
            placenieMS.Zamowienia = new List<ZamowieniaDoZaplacenia>();
            double _suma = 0;
            if (idZamowienia != null)
            {
                blZamowienie.getZamowienia().Where(i => i.id_stolik == idZamowienia).ToList().ForEach(zamowienie=>{
                    placenieMS.Zamowienia.Add(new ZamowieniaDoZaplacenia() {
                        id = zamowienie.id,
                        nazwaDania = blkartaDan.getKartaDan(zamowienie.id_kartaDan).nazwaDania,
                        rodzajDania = blTypDania.getTypDania(blkartaDan.getKartaDan(zamowienie.id_kartaDan).id_typDania).nazwaTypu,
                        cena = blkartaDan.getKartaDan(zamowienie.id_kartaDan).cena,
                     
                    });
                    _suma += blkartaDan.getKartaDan(zamowienie.id_kartaDan).cena;
                });

                placenieMS.Suma = _suma;
            }
            return View(placenieMS);

        }
    }
}
