using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Models
{
    public class KartaDan
    {
        [Key]
        public int id { set; get; }
        public string nazwaDania { set; get; }
        public float cena { set; get; }

        public List<Zamowienie> zamowienia { get; set; }
       
        public int id_typDania { set; get; }
        [ForeignKey(nameof(id_typDania))]
        [Column(TypeName ="id_typDania")]
        public TypDania typDania { set; get; }

    }
}
