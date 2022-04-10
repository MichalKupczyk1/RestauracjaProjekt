using AutoMapper;
using Moq;
using ProjektTaiib.Controllers;
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
    public class MockBuisiness {
        private readonly Mock<Restauracja> _restauracjaMock = new Mock<Restauracja>();
        private readonly Mock<IUnitOfWork> _UOWMock = new Mock<IUnitOfWork>();
        private readonly Mock<IMapper> _mapperMock = new Mock<IMapper>();
        private readonly BLKartaDan _kartaDan;

     
        [Fact]
        public void testBusinessKartaDanShouldBeEqual()
        { 
            var mockcos = Mock.Of<IKartaDanRepository>(c => c.getKartaDan(1).nazwaDania == "test");
            var uow = Mock.Of<IUnitOfWork>(c => c.KartaDan == mockcos);
            Assert.Equal("test", uow.KartaDan.getKartaDan(1).nazwaDania);

        }
        [Fact]
        public void testBusinessKartaDanShouldBeEqualAnotherWayOfDoingIt()
        {
            var repoMock = new Mock<IUnitOfWork>();
            repoMock.Setup(r => r.KartaDan.getKartaDan(10)).Returns(new KartaDan { id = 10, id_typDania = 1, nazwaDania = "MockTestNazwa", cena = 100 });

            var cos = new BLKartaDan(repoMock.Object);
            cos.getKartaDan(10);
            repoMock.Verify(r => r.KartaDan.getKartaDan(10));
            Assert.Equal("MockTestNazwa", cos.getKartaDan(10).nazwaDania);

        }
    }


}

        /*
         * 
         *
        public class MockBuisiness
        {
            private readonly Mock<Restauracja> _restauracjaMock = new Mock<Restauracja>();
            private readonly Mock<IUnitOfWork> _UOWMock = new Mock<IUnitOfWork>();
            private readonly BLKartaDan _kartaDan;
            public MockBuisiness()
            {
                _kartaDan = new BLKartaDan(_UOWMock.Object);
            }
            [Fact]
            public void test_Buisiness_BLKartaDan() {
                var nazwaDania = "test";
                var id = 1;


                KartaDan kartaDan = new KartaDan()
                {
                     id=id,cena = 100, nazwaDania = nazwaDania, id_typDania = 1
                };

                _UOWMock.Setup(x => x.KartaDan.addKartaDan(kartaDan));

                var cos = _kartaDan.getKartaDan(1);
                Assert.Null(cos);
              //  Assert.Equal(nazwaDania, kartaDan.nazwaDania);
                // _kartaDan.addKartaDan(kartaDan);
                //var karta = _kartaDan.GetKartyDan().FirstOrDefault() ;



                /*
               var mockcos = Mock.Of<IKartaDan>(c=>c.getKartaDan(1).nazwaDania == "test");
               UnitOfWork uow = new UnitOfWork(Mock.Of<Restauracja>(e=>e.kartaDan == mockcos));
               Assert.Equal("test",uow.KartaDan.getKartaDan(1).nazwaDania);

               var mockBuis = new MockBLKartaDan().MockIsValid(new Models.KartaDan());

               var pS = new BLKartaDan(new UnitOfWork(new Models.Restauracja()));

               var jeden = pS.getKartaDan(1);

               Assert.Empty((System.Collections.IEnumerable)jeden);
               mockBuis.VerifyIsValid(Times.Once());
               */

