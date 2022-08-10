using Moq;
using NUnit.Framework;
using ProjektTaiib.Interfaces;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektTaiib.Tests
{

   [TestFixture]
   public class FakeTest
    {
        [Test]
        public void fakeTestAddKartaDanShouldBeEqual() {
            var kartaDan = new FakeKartaDanRepository();
            kartaDan.addKartaDan(new KartaDan() {cena = 100, id_typDania=1, nazwaDania = "ziemniaki" });
            kartaDan.addKartaDan(new KartaDan() {cena = 100, id_typDania=1, nazwaDania = "zupa" });
            Assert.AreEqual("zupa", kartaDan.GetKartyDan().Last().nazwaDania);

        }
    }
}
