using ProjektTaiib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace ProjektTaiib.Tests
{

    [TestFixture]
    public class DummyTest
    {
        [Test]
        public void BLKartaDanNullKonstruktor() {
            UnitOfWork uow = null;
           Assert.Throws<ArgumentNullException>(() => new BLKartaDan(uow));
        }
    }
}
