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
    public class KelnerMockTest
    {
        [Test]
        public void veryfingDeleteKelner()
        {
            var kelner = Mock.Of<IKelnerRepository>(x => x.deleteKelner(1) == true);
            var validator = new KelnerValidator();
            validator.validate(kelner);

            Mock.Get(kelner).Verify(x => x.deleteKelner(1));
        }

        [Test]
        public void repoAndUOWMockTest()
        {
            var mockcos = Mock.Of<IKartaDanRepository>(c => c.getKartaDan(1).nazwaDania == "test");
            var uow = Mock.Of<IUnitOfWork>(c => c.KartaDan == mockcos);
            Assert.AreEqual("test", uow.KartaDan.getKartaDan(1).nazwaDania);
        }

        [Test]
        public void UOWMockTestShouldBeEqual()
        {
            var mockTypDania = Mock.Of<ITypDaniaRepository>(c => c.deleteTypDania(1) == true);
            var uowTypDania = Mock.Of<IUnitOfWork>(c => c.TypDania == mockTypDania);
            Assert.True(uowTypDania.TypDania.deleteTypDania(1));

            var mockKelner = Mock.Of<IKelnerRepository>(c => c.getKelner(1) == new Kelner() { nazwisko = "Kowalski" });
            var uowKelner = Mock.Of<IUnitOfWork>(c => c.Kelner == mockKelner);
            Assert.AreEqual("Kowalski", uowKelner.Kelner.getKelner(1).nazwisko);

            var mockStolik = Mock.Of<IStolikRepository>(c => c.deleteStolik(1) == true);
            var uowStolik = Mock.Of<IUnitOfWork>(c => c.Stolik == mockStolik);
            Assert.True( uowStolik.Stolik.deleteStolik(1));

            var mockZamowienie = Mock.Of<IZamowienieRepository>(c => c.getZamowienie(1) == new Zamowienie() { id = 1 });
            var uowZamowienie = Mock.Of<IUnitOfWork>(c => c.Zamowienie == mockZamowienie);
            Assert.AreEqual(1, uowZamowienie.Zamowienie.getZamowienie(1).id);
        }
    }
}
