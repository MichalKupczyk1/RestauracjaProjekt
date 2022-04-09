using ProjektTaiib.Interfaces;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektTaiib.Tests
{
    public class FakeUnitOfWork : IUnitOfWork
    {
        private readonly Restauracja dbContext = new Restauracja();
        private IKartaDanRepository _KartaDan;
   

        public IKartaDanRepository KartaDan
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

        public IKelnerRepository Kelner => throw new NotImplementedException();
        public IStolikRepository Stolik => throw new NotImplementedException();

        public ITypDaniaRepository TypDania => throw new NotImplementedException();

        public IZamowienieRepository Zamowienie => throw new NotImplementedException();

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public Task<int> CompleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
