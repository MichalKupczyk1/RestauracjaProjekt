using ProjektTaiib.Models;
using ProjektTaiib.MS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Interfaces
{
    public class KartaDanRepository : IKartaDanRepository
    {
        public KartaDanRepository(Restauracja baza)
        {
            this.baza = baza;
        }
        private Restauracja baza { get; set; }
        public void addKartaDan(KartaDan kartaDan)
        {
            baza.kartaDan.Add(kartaDan);
        }

        public bool deleteKartaDan(int id)
        {
            KartaDan temp = getKartaDan(id);

            if (temp != null)
            {
                baza.kartaDan.Remove(temp);
                return true;
            }
            return false;
        }

        public KartaDan getKartaDan(int id)
        {
            return baza.kartaDan.Where(e => e.id == id).FirstOrDefault();
        }

        public IEnumerable<KartaDan> GetKartyDan()
        {
            return baza.kartaDan.ToList();
        }
    }

    public class KelnerRepository : IKelnerRepository
    {
        public KelnerRepository(Restauracja baza)
        {
            this.baza = baza;
        }
        private Restauracja baza { get; set; }
        public void addKelner(Kelner kelner)
        {
            baza.kelner.Add(kelner);
        }

        public bool deleteKelner(int id)
        {
            Kelner temp = getKelner(id);

            if (temp != null)
            {
                baza.kelner.Remove(temp);
                return true;
            }
            return false;
        }

        public Kelner getKelner(int id)
        {
            return baza.kelner.Where(e => e.id == id).FirstOrDefault();
        }

        public IEnumerable<Kelner> getKelnerzy()
        {
            return baza.kelner.ToList();
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
        public StolikRepository(Restauracja baza)
        {
            this.baza = baza;
        }
        private Restauracja baza { get; set; }
        public void addStolik(Stolik stolik)
        {
            baza.stolik.Add(stolik);
        }

        public bool deleteStolik(int id)
        { 
            Stolik temp = getStolik(id);

            if (temp != null)
            {
                baza.stolik.Remove(temp);
                return true;
            }
            return false;
        }

        public Stolik getStolik(int id)
        {
            return baza.stolik.Where(e => e.id == id).FirstOrDefault();
        }

        public IEnumerable<Stolik> getStoliki()
        {
            return baza.stolik.ToList();
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
        public TypDaniaRepository(Restauracja baza)
        {
            this.baza = baza;
        }
        private Restauracja baza { get; set; }
        public void addTypDania(TypDania typDania)
        {
            baza.typDania.Add(typDania);
        }

        public bool deleteTypDania(int id)
        {
            TypDania temp = getTypDania(id);

            if (temp != null)
            {
                baza.typDania.Remove(temp);
                return true;
            }
            return false;
        }

        public TypDania getTypDania(int id)
        {
            return baza.typDania.Where(e => e.id == id).FirstOrDefault();
        }

        public IEnumerable<TypDania> getTypyDania()
        {
            return baza.typDania.ToList();
        }

        public void przypiszDoKartyDan(int idTypu, int idKarty)
        {
            throw new NotImplementedException();
        }
    }

    public class ZamowienieRepository : IZamowienieRepository
    {
        public ZamowienieRepository(Restauracja baza)
        {
            this.baza = baza;
        }
        private Restauracja baza { get; set; }
        public void addZamowienie(Zamowienie zamowienie)
        {
            baza.zamowienie.Add(zamowienie);
        }

        public bool deleteZamowienie(int id)
        {

            Zamowienie temp = getZamowienie(id);

            if (temp != null)
            {
                baza.zamowienie.Remove(temp);
                return true;
            }
            return false;
        }

        public IEnumerable<Zamowienie> getZamowienia()
        {
            return baza.zamowienie.ToList();
        }

        public Zamowienie getZamowienie(int id)
        {
            return baza.zamowienie.Where(e => e.id == id).FirstOrDefault();
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
