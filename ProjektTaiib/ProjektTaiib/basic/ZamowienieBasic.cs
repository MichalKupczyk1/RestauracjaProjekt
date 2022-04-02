using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.basic
{
    public class ZamowienieBasic
    {
        public int id { set; get; }
        public int id_stolik { set; get; }
  
        public int id_kartaDan { set; get; }
      
        public int id_kelner { set; get; }
      
        public DateTime? data_zam { set; get; }
    }
}
//no trzeba podobawać pare pol jeszcze tutaj i nazwe zmienic 
// To jest klasa zamowienia ale ona nie laczy sie z baza, z bazy jest rzutowane na to, i dopiero to jest wyswietlane