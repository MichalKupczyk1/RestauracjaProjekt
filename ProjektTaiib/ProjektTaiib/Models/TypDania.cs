using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Models
{
    public class TypDania
    {
        [Key]
        public int id { set; get; }
        public string nazwaTypu { set; get; }
        public List<KartaDan> Dania { get; set; }
    }
}
