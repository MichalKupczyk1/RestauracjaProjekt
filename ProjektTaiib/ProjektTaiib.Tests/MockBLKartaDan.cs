using Moq;
using ProjektTaiib.Interfaces;
using ProjektTaiib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektTaiib.Tests
{
    public class MockBLKartaDan : Mock<IKartaDan>
    {
        public MockBLKartaDan MockIsValid(KartaDan result)
        {
            Setup(x => x.getKartaDan(It.IsAny<int>()))
                .Returns(result);

            return this;
        }
        public MockBLKartaDan VerifyIsValid(Times times) {
            Verify(x => x.getKartaDan(It.IsAny<int>()), times);
            return this;
        }
    }
}
