using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Models
{
    public class Zamowienie
    {
        [Key]
        public int id { set; get; }

        public int id_stolik { set; get; }
        [ForeignKey(nameof(id_stolik))]
        public Stolik Stolik{ set; get; }

        public int id_kartaDan{ set; get; }
        [ForeignKey(nameof(id_kartaDan))]
        public KartaDan kartaDan { set; get; }

        public int id_kelner { set; get; }
        [ForeignKey(nameof(id_kelner))]
        public Kelner kelner { set; get; }

        [Column(TypeName ="Date")]
        public DateTime? data_zam { set; get; }
    }
}
