using Moq;
using NUnit.Framework;
using ProjektTaiib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektTaiib.Tests
{
    [TestFixture]
    public class KelnerStubTest
    {
        [Test]
        public void checkingIfKelnerGotDeleted()
        {
            var kelner = Mock.Of<IKelnerRepository>(c => c.deleteKelner(1)==true);
            var validator = new KelnerValidator();

            bool validate = validator.validate(kelner);

            Assert.True(validate);
        }
    }

    public class KelnerValidator
    {
        public bool validate(IKelnerRepository repo)
        {
            return repo.deleteKelner(1) == true;
        }
    }

}
