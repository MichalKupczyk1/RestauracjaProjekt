using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Interfaces
{   
    public interface IKartaDan
    {
        void addKartaDan(KartaDan kartaDan);
        bool deleteKartaDan(int id);
        IEnumerable<KartaDan> GetKartyDan();
        KartaDan getKartaDan(int id);

    }

    public interface IKelner
    {
        void addKelner(Kelner kelner);
        bool deleteKelner(int id);
        IEnumerable<Kelner> getKelnerzy();
        Kelner getKelner(int id);
        void przypiszDoZamowienia(int idZamowienia, int idKelnera);
        IEnumerable<Zamowienie> getZamowieniaKelnera(int kelnerId);

    }
    public interface IDodaj 
    { 
    
    }
    public interface IStolik
    {
        void addStolik(Stolik stolik);
        bool deleteStolik(int id);
        IEnumerable<Stolik> getStoliki();
        public void zajmowanieIStolik(int id);
        Stolik getStolik(int id);
        void przypiszDoZamowienia(int idZamowienia, int idStolika);
        IEnumerable<Zamowienie> getZamowieniaStolika(int stolikId);
    }

    public interface ITypDania
    {
        void addTypDania(TypDania typDania);
        bool deleteTypDania(int id);
        IEnumerable<TypDania> getTypyDania();
        TypDania getTypDania(int id);
        void przypiszDoKartyDan(int idTypu, int idKarty);
    }

    public interface IZamowienie
    {
        void addZamowienie(Zamowienie zamowienie);
        bool deleteZamowienie(int id);
        IEnumerable<Zamowienie> getZamowienia();
        Zamowienie getZamowienie(int id);
        void przypiszZamowienieDoStolika(int idZamowienie, int idStolik);
        void przypiszZamowienieDoKelnera(int idZamowienie, int idKelner);
        void przypiszZamowienieDoKartyDan(int idZamowienie, int idKartaDan);
    
    }

}
