using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Interfaces
{
    class BLKartaDan : IKartaDan
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
            unitOfWork.kartaDan.addKartaDan(kartaDan);
        }

        public bool deleteKartaDan(int id)
        {
            if (id <= default(int))
                throw new InvalidOperationException("Podane id nie jest poprawne");

            var isRemoved = unitOfWork.kartaDan.deleteKartaDan(id);
            if (isRemoved)
                unitOfWork.Complete();
            return isRemoved;
        }

        public KartaDan getKartaDan(int id)
        {
            if (id <= default(int))
                throw new InvalidOperationException("Podane id nie jest poprawne");

            return unitOfWork.kartaDan.getKartaDan(id);
        }

        public IEnumerable<KartaDan> GetKartyDan()
        {
            //tu dodaj mozliwosc zwrocenia listy w uow
            return null;
        }
    }

    class BLKelner : IKelner
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
            unitOfWork.kelner.addKelner(kelner);
        }

        public bool deleteKelner(int id)
        {
            if (id <= default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");

            var isRemoved = unitOfWork.kelner.deleteKelner(id);
            if (isRemoved)
                unitOfWork.Complete();
            return isRemoved;
        }

        public Kelner getKelner(int id)
        {
            if (id <= default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");

            return unitOfWork.kelner.getKelner(id);
        }

        public IEnumerable<Kelner> getKelnerzy()
        {
            return unitOfWork.kelner.getKelnerzy();
        }

        public IEnumerable<Zamowienie> getZamowieniaKelnera(int kelnerId)
        {
            if (kelnerId <= default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");

            if(unitOfWork.kelner.getKelner(kelnerId)==null)
                throw new InvalidOperationException("Dany kelner nie istnieje");

            return unitOfWork.kelner.getZamowieniaKelnera(kelnerId);
        }

        public void przypiszDoZamowienia(int idZamowienia, int idKelnera)
        {
            if(idKelnera<=default(int))
                throw new InvalidOperationException("Podane id kelnera jest nieprawidłowe");
            if(idZamowienia<=default(int))
                throw new InvalidOperationException("Podane id zamowienia jest nieprawidłowe");
            if(unitOfWork.kelner.getKelner(idKelnera)==null)
                throw new InvalidOperationException("Dany kelner nie istnieje");
            if(unitOfWork.zamowienie.getZamowienie(idZamowienia)==null)
                throw new InvalidOperationException("Dane zamowienie nie istnieje");

            unitOfWork.kelner.przypiszDoZamowienia(idZamowienia, idKelnera);
        }
    }

    class BLStolik : IStolik
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
            unitOfWork.stolik.addStolik(stolik);
        }

        public bool deleteStolik(int id)
        {
            if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            var isRemoved = unitOfWork.stolik.deleteStolik(id);
            if (isRemoved)
                unitOfWork.Complete();
            return isRemoved;
        }

        public Stolik getStolik(int id)
        {
           if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            return unitOfWork.stolik.getStolik(id);
        }

        public IEnumerable<Stolik> getStoliki()
        {
            return unitOfWork.stolik.getStoliki();
        }

        public IEnumerable<Zamowienie> getZamowieniaStolika(int stolikId)
        {
            if(stolikId<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            if(unitOfWork.stolik.getStolik(stolikId)==null)
                throw new InvalidOperationException("Dany stolik nie istnieje");

            return unitOfWork.stolik.getZamowieniaStolika(stolikId);

        }

        public void przypiszDoZamowienia(int idZamowienia, int idStolika)
        {
            if(idZamowienia<=default(int))
                throw new InvalidOperationException("Podane id zamowienia jest nieprawidłowe");
            if(idStolika<=default(int))
                throw new InvalidOperationException("Podane id stolika jest nieprawidłowe");
            if(unitOfWork.stolik.getStolik(idStolika)==null)
                throw new InvalidOperationException("Dany stolik nie istnieje");
            if(unitOfWork.zamowienie.getZamowienie(idZamowienia)==null)
                throw new InvalidOperationException("Dane zamowienie nie istnieje");

            unitOfWork.stolik.przypiszDoZamowienia(idZamowienia, idStolika);
        }
    }

    class BLTypDania : ITypDania
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
            unitOfWork.typDania.addTypDania(typDania);
        }

        public bool deleteTypDania(int id)
        {
            if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            var isRemoved = unitOfWork.typDania.deleteTypDania(id);
            if (isRemoved)
                unitOfWork.Complete();
            return isRemoved;
        }

        public TypDania getTypDania(int id)
        {
            if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            return unitOfWork.typDania.getTypDania(id);
        }

        public IEnumerable<TypDania> getTypyDania()
        {
            return unitOfWork.typDania.getTypyDania();
        }

        public void przypiszDoKartyDan(int idTypu, int idKarty)
        {
           if(idKarty<=default(int))
                throw new InvalidOperationException("Podane id karty jest nieprawidłowe");
           if(idTypu<=default(int))
                throw new InvalidOperationException("Podane id typu jest nieprawidłowe");
           if(unitOfWork.kartaDan.getKartaDan(idKarty)==null)
                throw new InvalidOperationException("Dana karta nie istnieje");
           if(unitOfWork.typDania.getTypDania(idTypu)==null)
                throw new InvalidOperationException("Dany typ dania nie istnieje");
            unitOfWork.typDania.przypiszDoKartyDan(idTypu, idKarty);
        }
    }

    class BLZamowienie : IZamowienie
    {
        private UnitOfWork unitOfWork;

        public BLZamowienie(UnitOfWork uow)
        {
            this.unitOfWork = uow;
        }
        public void addZamowienie(Zamowienie zamowienie)
        {
            if(zamowienie==null)
                throw new InvalidOperationException("Podane zamówienie nie istnieje");
            unitOfWork.zamowienie.addZamowienie(zamowienie);
        }

        public bool deleteZamowienie(int id)
        {
            if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            var isRemoved = unitOfWork.zamowienie.deleteZamowienie(id);

            if (isRemoved)
                unitOfWork.Complete();
            return isRemoved;
        }

        public IEnumerable<Zamowienie> getZamowienia()
        {
            return unitOfWork.zamowienie.getZamowienia();
        }

        public Zamowienie getZamowienie(int id)
        {
            if(id<=default(int))
                throw new InvalidOperationException("Podane id jest nieprawidłowe");
            return unitOfWork.zamowienie.getZamowienie(id);
        }

        public void przypiszZamowienieDoKartyDan(int idZamowienie, int idKartaDan)
        {
            if(idKartaDan<=default(int))
                throw new InvalidOperationException("Podane id karty dań jest nieprawidłowe");
            if(idZamowienie<=default(int))
                throw new InvalidOperationException("Podane id zamówienia jest nieprawidłowe");
            if(unitOfWork.zamowienie.getZamowienie(idZamowienie)==null)
                throw new InvalidOperationException("Podane zamówienie nie istnieje");
            if(unitOfWork.kartaDan.getKartaDan(idKartaDan)==null)
                throw new InvalidOperationException("Podana karta dań nie istnieje");
            unitOfWork.zamowienie.przypiszZamowienieDoKartyDan(idZamowienie, idKartaDan);
        }

        public void przypiszZamowienieDoKelnera(int idZamowienie, int idKelner)
        {
            if (idKelner <= default(int))
                throw new InvalidOperationException("Podane id kelnera jest nieprawidłowe");
            if (idZamowienie <= default(int))
                throw new InvalidOperationException("Podane id zamówienia jest nieprawidłowe");
            if (unitOfWork.zamowienie.getZamowienie(idZamowienie) == null)
                throw new InvalidOperationException("Podane zamówienie nie istnieje");
            if (unitOfWork.kelner.getKelner(idKelner) == null)
                throw new InvalidOperationException("Podany kelner nie istnieje");
            unitOfWork.zamowienie.przypiszZamowienieDoKelnera(idZamowienie, idKelner);
        }

        public void przypiszZamowienieDoStolika(int idZamowienie, int idStolik)
        {
            if (idStolik <= default(int))
                throw new InvalidOperationException("Podane id stolika jest nieprawidłowe");
            if (idZamowienie <= default(int))
                throw new InvalidOperationException("Podane id zamówienia jest nieprawidłowe");
            if (unitOfWork.zamowienie.getZamowienie(idZamowienie) == null)
                throw new InvalidOperationException("Podane zamówienie nie istnieje");
            if (unitOfWork.stolik.getStolik(idStolik) == null)
                throw new InvalidOperationException("Podany stolik istnieje");
            unitOfWork.zamowienie.przypiszZamowienieDoStolika(idZamowienie, idStolik);
        }
    }

}
