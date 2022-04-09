using ProjektTaiib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace ProjektTaiib.Tests
{
  
    public class DummyTest
    {
        [Fact]
        public void BLKartaDan_null_konstruktor() {
            UnitOfWork uow = null;
           Assert.Throws<ArgumentNullException>(() => new BLKartaDan(uow));
        }
    }
}
