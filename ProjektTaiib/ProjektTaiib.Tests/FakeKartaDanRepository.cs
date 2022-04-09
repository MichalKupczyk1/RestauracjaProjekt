using ProjektTaiib.Interfaces;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektTaiib.Tests
{
    class FakeKartaDanRepository : IKartaDanRepository
    {
        List<KartaDan> kartyDan = new List<KartaDan>();
        public void addKartaDan(KartaDan kartaDan)
        {
            kartyDan.Add(kartaDan);
        }

        public bool deleteKartaDan(int id)
        {
            throw new NotImplementedException();
        }

        public KartaDan getKartaDan(int id)
        {
            return kartyDan.Where(e => e.id == id).FirstOrDefault();
        }

        public IEnumerable<KartaDan> GetKartyDan()
        {
            return kartyDan.ToList();
        }
    }
}
