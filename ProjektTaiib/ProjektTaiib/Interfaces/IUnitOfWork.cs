using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Interfaces
{
    public interface IUnitOfWork
    {
        IKelnerRepository Kelner { get; }
        IKartaDanRepository KartaDan  { get; }
        IStolikRepository Stolik{ get; }
        ITypDaniaRepository TypDania { get; }
        IZamowienieRepository Zamowienie { get; }
        Task<int> CompleteAsync();
        int Complete();
    }
}
