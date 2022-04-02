using Microsoft.AspNetCore.Mvc;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.basic
{
    public class KelnerBasic : Controller
    {
        public int id { set; get; }
        public string imie { set; get; }
        public string nazwisko { set; get; }
    }
}
