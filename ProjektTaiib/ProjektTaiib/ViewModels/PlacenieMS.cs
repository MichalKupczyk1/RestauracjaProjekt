using Microsoft.AspNetCore.Mvc;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.ViewModels
{
    public class PlacenieMS
    {
        public List<ZamowieniaDoZaplacenia> Zamowienia { set; get; }
        public double Suma {set;get;}
    }
    public class ZamowieniaDoZaplacenia {
        public int id { set; get; }
        public string nazwaDania { set; get; }
        public string rodzajDania { set; get; }
        public double cena { set; get; }
    }
}
