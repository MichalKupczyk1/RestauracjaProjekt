using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Interfaces
{
    public class BLKartaDan : IKartaDan
    {
        private UnitOfWork unitOfWork;

        public BLKartaDan(UnitOfWork uow)
        {
            this.unitOfWork = uow;
        }
        public void addKartaDan(KartaDan kartaDan)
        {
            if (kartaDan == null)
                throw new InvalidOperationException("Podana karta nie istnieje");
            unitOfWork.KartaDan.addKartaDan(kartaDan);
        }

        public bool deleteKartaDan(int id)
        {
            if (id <= default(int))
                throw new InvalidOperationException("Podane id nie jest poprawne");

            var isRemoved = unitOfWork.KartaDan.deleteKartaDan(id);
            if (isRemoved)
                unitOfWork.Complete();
            return isRemoved;
        }

        public KartaDan getKartaDan(int id)
        {
            Console.WriteLine("aaaaaaaaaaaaaa"+id);
            if (id <= default(int))
                throw new InvalidOperationException("Podane id nie jest poprawne " + id);

            return unitOfWork.KartaDan.getKartaDan(id);
        }

        public IEnumerable<KartaDan> GetKartyDan()
        {

            //tu dodaj mozliwosc zwrocenia listy w uow
            return unitOfWork.KartaDan.GetKartyDan();
        }
    }

    public class BLKelner : IKelner
     {
        private UnitOfWork unitOfWork;

        public BLKelner(UnitOfWork uow)
        {
            this.unitOfWork = uow;
        }
        public void addKelner(Kelner kelner)
        {
            if (kelner == null)
                throw new InvalidOperationException("Podany kelner nie istnieje");
            unitOfWork.Kelner.addKelner(kelner);
        }

        public bool deleteKelner(int id)
        {
            if (id <= default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");

            var isRemoved = unitOfWork.Kelner.deleteKelner(id);
            if (isRemoved)
                unitOfWork.Complete();
            return isRemoved;
        }

        public Kelner getKelner(int id)
        {
            if (id <= default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");

            return unitOfWork.Kelner.getKelner(id);
        }

        public IEnumerable<Kelner> getKelnerzy()
        {
            return unitOfWork.Kelner.getKelnerzy();
        }

        public IEnumerable<Zamowienie> getZamowieniaKelnera(int kelnerId)
        {
          //  if (kelnerId <= default(int))
         //       throw new InvalidOperationException("Podane id jest nieprawidłowe");

            if(unitOfWork.Kelner.getKelner(kelnerId)==null)
                throw new InvalidOperationException("Dany kelner nie istnieje");

            return unitOfWork.Kelner.getZamowieniaKelnera(kelnerId);
        }

        public void przypiszDoZamowienia(int idZamowienia, int idKelnera)
        {
            if(idKelnera<=default(int))
                throw new InvalidOperationException("Podane id kelnera jest nieprawidłowe");
            if(idZamowienia<=default(int))
                throw new InvalidOperationException("Podane id zamowienia jest nieprawidłowe");
            if(unitOfWork.Kelner.getKelner(idKelnera)==null)
                throw new InvalidOperationException("Dany kelner nie istnieje");
            if(unitOfWork.Zamowienie.getZamowienie(idZamowienia)==null)
                throw new InvalidOperationException("Dane zamowienie nie istnieje");

            unitOfWork.Kelner.przypiszDoZamowienia(idZamowienia, idKelnera);
        }
    }

    public class BLStolik : IStolik
    {
        private UnitOfWork unitOfWork;

        public BLStolik(UnitOfWork uow)
        {
            this.unitOfWork = uow;
        }
        public void addStolik(Stolik stolik)
        {
            if(stolik==null)
                throw new InvalidOperationException("Podany stolik nie istnieje");
            unitOfWork.Stolik.addStolik(stolik);
        }

        public bool deleteStolik(int id)
        {
            if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            var isRemoved = unitOfWork.Stolik.deleteStolik(id);
            if (isRemoved)
                unitOfWork.Complete();
            return isRemoved;
        }

        public Stolik getStolik(int id)
        {
           if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            return unitOfWork.Stolik.getStolik(id);
        }

        public IEnumerable<Stolik> getStoliki()
        {
            return unitOfWork.Stolik.getStoliki();
        }

        public IEnumerable<Zamowienie> getZamowieniaStolika(int stolikId)
        {
            if(stolikId<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            if(unitOfWork.Stolik.getStolik(stolikId)==null)
                throw new InvalidOperationException("Dany stolik nie istnieje");

            return unitOfWork.Stolik.getZamowieniaStolika(stolikId);

        }

        public void przypiszDoZamowienia(int idZamowienia, int idStolika)
        {
            if(idZamowienia<=default(int))
                throw new InvalidOperationException("Podane id zamowienia jest nieprawidłowe");
            if(idStolika<=default(int))
                throw new InvalidOperationException("Podane id stolika jest nieprawidłowe");
            if(unitOfWork.Stolik.getStolik(idStolika)==null)
                throw new InvalidOperationException("Dany stolik nie istnieje");
            if(unitOfWork.Zamowienie.getZamowienie(idZamowienia)==null)
                throw new InvalidOperationException("Dane zamowienie nie istnieje");

            unitOfWork.Stolik.przypiszDoZamowienia(idZamowienia, idStolika);
        }
    }

    public class BLTypDania : ITypDania
    {
        private UnitOfWork unitOfWork;

        public BLTypDania(UnitOfWork uow)
        {
            this.unitOfWork = uow;
        }
        public void addTypDania(TypDania typDania)
        {
            if(typDania==null)
                throw new InvalidOperationException("Dany typ dania jest nieprawidłowy");
            unitOfWork.TypDania.addTypDania(typDania);
        }

        public bool deleteTypDania(int id)
        {
            if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            var isRemoved = unitOfWork.TypDania.deleteTypDania(id);
            if (isRemoved)
                unitOfWork.Complete();
            return isRemoved;
        }

        public TypDania getTypDania(int id)
        {
            if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            return unitOfWork.TypDania.getTypDania(id);
        }

        public IEnumerable<TypDania> getTypyDania()
        {
            return unitOfWork.TypDania.getTypyDania();
        }

        public void przypiszDoKartyDan(int idTypu, int idKarty)
        {
           if(idKarty<=default(int))
                throw new InvalidOperationException("Podane id karty jest nieprawidłowe");
           if(idTypu<=default(int))
                throw new InvalidOperationException("Podane id typu jest nieprawidłowe");
           if(unitOfWork.KartaDan.getKartaDan(idKarty)==null)
                throw new InvalidOperationException("Dana karta nie istnieje");
           if(unitOfWork.TypDania.getTypDania(idTypu)==null)
                throw new InvalidOperationException("Dany typ dania nie istnieje");
            unitOfWork.TypDania.przypiszDoKartyDan(idTypu, idKarty);
        }
    }

    public class BLZamowienie : IZamowienie
    {
        private readonly IUnitOfWork unitOfWork;

        public BLZamowienie(IUnitOfWork uow)
        {
            this.unitOfWork = uow;
        }
        public void addZamowienie(Zamowienie zamowienie)
        {
            if(zamowienie==null)
                throw new InvalidOperationException("Podane zamówienie nie istnieje");
            unitOfWork.Zamowienie.addZamowienie(zamowienie);
        }

        public bool deleteZamowienie(int id)
        {
            if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            var isRemoved = unitOfWork.Zamowienie.deleteZamowienie(id);

            if (isRemoved)
                unitOfWork.Complete();
            return isRemoved;
        }

        public IEnumerable<Zamowienie> getZamowienia()
        {
            return unitOfWork.Zamowienie.getZamowienia();
        }

        public Zamowienie getZamowienie(int id)
        {
            if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            return unitOfWork.Zamowienie.getZamowienie(id);
        }

        public void przypiszZamowienieDoKartyDan(int idZamowienie, int idKartaDan)
        {
            if(idKartaDan<=default(int))
                throw new InvalidOperationException("Podane id karty dań jest nieprawidłowe");
            if(idZamowienie<=default(int))
                throw new InvalidOperationException("Podane id zamówienia jest nieprawidłowe");
            if(unitOfWork.Zamowienie.getZamowienie(idZamowienie)==null)
                throw new InvalidOperationException("Podane zamówienie nie istnieje");
            if(unitOfWork.KartaDan.getKartaDan(idKartaDan)==null)
                throw new InvalidOperationException("Podana karta dań nie istnieje");
            unitOfWork.Zamowienie.przypiszZamowienieDoKartyDan(idZamowienie, idKartaDan);
        }

        public void przypiszZamowienieDoKelnera(int idZamowienie, int idKelner)
        {
            if (idKelner <= default(int))
                throw new InvalidOperationException("Podane id kelnera jest nieprawidłowe");
            if (idZamowienie <= default(int))
                throw new InvalidOperationException("Podane id zamówienia jest nieprawidłowe");
            if (unitOfWork.Zamowienie.getZamowienie(idZamowienie) == null)
                throw new InvalidOperationException("Podane zamówienie nie istnieje");
            if (unitOfWork.Kelner.getKelner(idKelner) == null)
                throw new InvalidOperationException("Podany kelner nie istnieje");
            unitOfWork.Zamowienie.przypiszZamowienieDoKelnera(idZamowienie, idKelner);
        }

        public void przypiszZamowienieDoStolika(int idZamowienie, int idStolik)
        {
            if (idStolik <= default(int))
                throw new InvalidOperationException("Podane id stolika jest nieprawidłowe");
            if (idZamowienie <= default(int))
                throw new InvalidOperationException("Podane id zamówienia jest nieprawidłowe");
            if (unitOfWork.Zamowienie.getZamowienie(idZamowienie) == null)
                throw new InvalidOperationException("Podane zamówienie nie istnieje");
            if (unitOfWork.Stolik.getStolik(idStolik) == null)
                throw new InvalidOperationException("Podany stolik istnieje");
            unitOfWork.Zamowienie.przypiszZamowienieDoStolika(idZamowienie, idStolik);
        }
    }

}
