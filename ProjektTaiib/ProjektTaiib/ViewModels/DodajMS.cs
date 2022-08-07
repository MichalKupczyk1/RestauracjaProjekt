using ProjektTaiib.basic;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.ViewModels
{
    public class DodajMS
    {
        public List<Stolik> Stoliki { set; get; }
        public List<KartaDan> KartyDan { set; get; }
        public List<Kelner> Kelnerzy { set; get; }
        public List<Zamowienie> Zamowienia { set; get; }
        public List<DodajZ> dodajZs { set; get; }
        public string aaa { set; get; }
        public int id_zamowienia { set; get; }
    }
    public class DodajZ
    {
        public int id { set; get; }
        public string nazwa { set; get; }
        public string rodzajDania { set; get; }
        public double cena { set; get; }
        public string imie { set; get; }
        public int id_zamowienia { set; get; }
    }
}
