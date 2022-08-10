using AutoMapper;
using Moq;
using ProjektTaiib.Controllers;
using ProjektTaiib.Interfaces;
using ProjektTaiib.Mapper;
using ProjektTaiib.Models;
using NUnit;
using NUnit.Framework;

namespace ProjektTaiib.Tests
{
    [TestFixture]
    public class ControllerTest
    {
        private readonly IMapper mapper;

        [Test]
        public void KelnerControllerTest()
        {
            var repoMock = new Mock<IUnitOfWork>();

            repoMock.Setup(r => r.Kelner.getKelner(1)).Returns(new Kelner { id = 1, imie = "Jan", nazwisko = "Ronaldo", zamowienia = null });

            var kelner = new Kelner { id = 1, imie = "Jan", nazwisko = "Ronaldo", zamowienia = null };

            var BLMock = new BLKelner(repoMock.Object);

            var kelnerController = new KelnerController(mapper, BLMock);

            var result = kelnerController.Get(1);

            Assert.AreEqual("Jan", result.imie);
        }
    }
}
