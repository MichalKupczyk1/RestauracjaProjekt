using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Interfaces
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Restauracja dbContext;
        public UnitOfWork(Restauracja dbContext)
        {
            this.dbContext = dbContext;
        }
        private IKelnerRepository _kelner;
        private IKartaDanRepository _KartaDan;
        private IStolikRepository _Stolik;
        private ITypDaniaRepository _TypDania;
        private IZamowienieRepository _Zamowienie;
        public IKelnerRepository kelner
        {
            get{
                if(this._kelner == null){
                    this._kelner = new KelnerRepository(dbContext);
                }
                return this._kelner;
            }
        }

        public IKartaDanRepository kartaDan
        {
            get
            {
                if (this._KartaDan == null)
                {
                    this._KartaDan = new KartaDanRepository(dbContext);
                }
                return this._KartaDan;
            }
        }

        public IStolikRepository stolik
        {
            get
            {
                if (this._Stolik == null)
                {
                    this._Stolik = new StolikRepository(dbContext);
                }
                return this._Stolik;
            }
        }

        public ITypDaniaRepository typDania
        {
            get
            {
                if (this._TypDania == null)
                {
                    this._TypDania = new TypDaniaRepository(dbContext);
                }
                return this._TypDania;
            }
        }
        public IZamowienieRepository zamowienie
        {
            get
            {
                if (this._Zamowienie == null)
                {
                    this._Zamowienie = new ZamowienieRepository(dbContext);
                }
                return this._Zamowienie;
            }
        }

        public int Complete()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
        public void Dispose() => dbContext.Dispose();

    }
}
