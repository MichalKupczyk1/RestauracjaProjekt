using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Interfaces
{
    public interface IKartaDanRepository
    {
        void addKartaDan(KartaDan kartaDan);
        bool deleteKartaDan(int id);
        IEnumerable<KartaDan> GetKartyDan();
        KartaDan getKartaDan(int id);
    }
    public interface IKelnerRepository
    {
        void addKelner(Kelner kelner);
        bool deleteKelner(int id);
        IEnumerable<Kelner> getKelnerzy();
        Kelner getKelner(int id);
        void przypiszDoZamowienia(int idZamowienia,int idKelnera);
        IEnumerable<Zamowienie> getZamowieniaKelnera(int kelnerId);
    }
    public interface IStolikRepository
    {
        void addStolik(Stolik stolik);
        bool deleteStolik(int id);
        IEnumerable<Stolik> getStoliki();
        Stolik getStolik(int id);
        void przypiszDoZamowienia(int idZamowienia,int idStolika);
        IEnumerable<Zamowienie> getZamowieniaStolika(int stolikId);
    }
    public interface ITypDaniaRepository
    {
        void addTypDania(TypDania typDania);
        bool deleteTypDania(int id);
        IEnumerable<TypDania> getTypyDania();
        TypDania getTypDania(int id);
        void przypiszDoKartyDan(int idTypu, int idKarty);
    }
    public interface IZamowienieRepository
    {
        
    }
}
