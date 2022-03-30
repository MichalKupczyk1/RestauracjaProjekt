using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Models
{
    public class Kelner
    {
        [Key]
        public int id { set; get; }
        public string imie{ set; get; }
        public string nazwisko{ set; get; }
        public List<Zamowienie> zamowienia { get; set; }

    }
}
