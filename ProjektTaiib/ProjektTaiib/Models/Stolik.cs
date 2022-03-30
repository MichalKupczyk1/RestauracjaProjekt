using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Models
{
    public class Stolik
    {
        [Key]
        public int id { set; get; }
        public int ileMiejsc { set; get; }
        public bool czyZajety { set; get; }
        public bool czyObsluzony { set; get; }
        public List<Zamowienie> zamowienia { get; set; }
    }
}
