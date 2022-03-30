using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Interfaces
{
    public class KartaDanRepository : IKartaDanRepository
    {
        public void addKartaDan(KartaDan kartaDan)
        {
            throw new NotImplementedException();
        }

        public bool deleteKartaDan(int id)
        {
            throw new NotImplementedException();
        }

        public KartaDan getKartaDan(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KartaDan> GetKartyDan()
        {
            throw new NotImplementedException();
        }
    }

    public class KelnerRepository : IKelnerRepository
    {
        public void addKelner(Kelner kelner)
        {
            throw new NotImplementedException();
        }

        public bool deleteKelner(int id)
        {
            throw new NotImplementedException();
        }

        public Kelner getKelner(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Kelner> getKelnerzy()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Zamowienie> getZamowieniaKelnera(int kelnerId)
        {
            throw new NotImplementedException();
        }

        public void przypiszDoZamowienia(int idZamowienia, int idKelnera)
        {
            throw new NotImplementedException();
        }
    }

    public class StolikRepository : IStolikRepository
    {
        public void addStolik(Stolik stolik)
        {
            throw new NotImplementedException();
        }

        public bool deleteStolik(int id)
        {
            throw new NotImplementedException();
        }

        public Stolik getStolik(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stolik> getStoliki()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Zamowienie> getZamowieniaStolika(int stolikId)
        {
            throw new NotImplementedException();
        }

        public void przypiszDoZamowienia(int idZamowienia, int idStolika)
        {
            throw new NotImplementedException();
        }
    }

    public class TypDaniaRepository : ITypDaniaRepository
    {
        public void addTypDania(TypDania typDania)
        {
            throw new NotImplementedException();
        }

        public bool deleteTypDania(int id)
        {
            throw new NotImplementedException();
        }

        public TypDania getTypDania(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TypDania> getTypyDania()
        {
            throw new NotImplementedException();
        }

        public void przypiszDoKartyDan(int idTypu, int idKarty)
        {
            throw new NotImplementedException();
        }
    }

    public class ZamowienieRepository : IZamowienieRepository
    {
        public void addZamowienie(Zamowienie zamowienie)
        {
            throw new NotImplementedException();
        }

        public bool deleteZamowienie(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Zamowienie> getZamowienia()
        {
            throw new NotImplementedException();
        }

        public Zamowienie getZamowienie(int id)
        {
            throw new NotImplementedException();
        }

        public void przypiszZamowienieDoKartyDan(int idZamowienie, int idKartaDan)
        {
            throw new NotImplementedException();
        }

        public void przypiszZamowienieDoKelnera(int idZamowienie, int idKelner)
        {
            throw new NotImplementedException();
        }

        public void przypiszZamowienieDoStolika(int idZamowienie, int idStolik)
        {
            throw new NotImplementedException();
        }
    }
}
