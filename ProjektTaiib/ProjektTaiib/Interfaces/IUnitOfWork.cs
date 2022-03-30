using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektTaiib.Interfaces
{
    public interface IUnitOfWork
    {
        IKelnerRepository kelner { get; }
        IKartaDanRepository kartaDan  { get; }
        IStolikRepository stolik{ get; }
        ITypDaniaRepository typDania { get; }
        IZamowienieRepository zamowienie { get; }
        Task<int> CompleteAsync();
        int Complete();
    }
}
