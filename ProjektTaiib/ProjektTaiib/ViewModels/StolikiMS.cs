using ProjektTaiib.basic;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.ViewModels
{
    public class StolikiMS
    {
        public List<Stolik> Stoliki { set; get; }
        public Stolik ZazStolik {set;get;}
        public int ZaznaczonyId { get; set; }
        public int PodanaIloscMiejsc { get; set; }
        public int IloscMiejscWSumie { get; set; }
        public int iloscWolnychStolikow { set; get; }
    }
}
