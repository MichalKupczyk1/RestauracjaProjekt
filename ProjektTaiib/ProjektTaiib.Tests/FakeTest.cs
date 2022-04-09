using ProjektTaiib.Interfaces;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjektTaiib.Tests
{
   
   public class FakeTest
    {
        [Fact]
        public void Test_add() { 
        FakeUnitOfWork fakeUOW = new FakeUnitOfWork();
        IKartaDan kartaDan = new BLKartaDan(fakeUOW);
            kartaDan.addKartaDan(new KartaDan {  nazwaDania="zupa"});   
            kartaDan.addKartaDan(new KartaDan {  id_typDania =0,id = 0,cena=3,nazwaDania="ziemniaki"});

            IEnumerable<KartaDan> test = fakeUOW.KartaDan.GetKartyDan();

            Assert.Equal("ziemniaki", test.Select(e => e.nazwaDania).Last());

        }
    }
}
