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
    public class KelnerMockTest
    {
        [Fact]
        public void test()
        {
            var kelner = Mock.Of<IKelnerRepository>(x => x.deleteKelner(1) == true);
            var validator = new KelnerValidator();
            validator.validate(kelner);

            Mock.Get(kelner).Verify(x => x.deleteKelner(1));
        }

        [Fact]
        public void businessTest()
        {
            var mockcos = Mock.Of<IKartaDanRepository>(c => c.getKartaDan(1).nazwaDania == "test");
            var uow = Mock.Of<IUnitOfWork>(c => c.KartaDan == mockcos);
            Assert.Equal("test", uow.KartaDan.getKartaDan(1).nazwaDania);
        }

        [Fact]
        public void mockUow()
        {
            var mockTypDania = Mock.Of<ITypDaniaRepository>(c => c.deleteTypDania(1) == true);
            var uowTypDania = Mock.Of<IUnitOfWork>(c => c.TypDania == mockTypDania);
            Assert.Equal(true, uowTypDania.TypDania.deleteTypDania(1));

            var mockKelner = Mock.Of<IKelnerRepository>(c => c.getKelner(1) == new Kelner() { nazwisko = "Kowalski" });
            var uowKelner = Mock.Of<IUnitOfWork>(c => c.Kelner == mockKelner);
            Assert.Equal("Kowalski", uowKelner.Kelner.getKelner(1).nazwisko);

            var mockStolik = Mock.Of<IStolikRepository>(c => c.deleteStolik(1)==true);
            var uowStolik = Mock.Of<IUnitOfWork>(c => c.Stolik == mockStolik);
            Assert.Equal(true,uowStolik.Stolik.deleteStolik(1));

            var mockZamowienie = Mock.Of<IZamowienieRepository>(c => c.getZamowienie(1) == new Zamowienie() { id = 1 }) ;
            var uowZamowienie = Mock.Of<IUnitOfWork>(c => c.Zamowienie==mockZamowienie);
            Assert.Equal(1, uowZamowienie.Zamowienie.getZamowienie(1).id);
        }
    }
}
