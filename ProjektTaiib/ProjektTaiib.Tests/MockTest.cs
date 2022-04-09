using Moq;
using ProjektTaiib.Interfaces;
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
            var kelner = Mock.Of<IKelnerRepository>(c => c.deleteKelner(1) == true);

            kelner.deleteKelner(1);
            Mock.Get(kelner).Verify(x => x.deleteKelner(1));
        }
    }
}
