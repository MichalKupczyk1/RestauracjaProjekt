using Moq;
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
            var kartaDan = new FakeKartaDanRepository();
            kartaDan.addKartaDan(new KartaDan() {cena = 100, id_typDania=1, nazwaDania = "ziemniaki" });
            kartaDan.addKartaDan(new KartaDan() {cena = 100, id_typDania=1, nazwaDania = "zupa" });
            Assert.Equal("zupa", kartaDan.GetKartyDan().Last().nazwaDania);

        }
    }
}
