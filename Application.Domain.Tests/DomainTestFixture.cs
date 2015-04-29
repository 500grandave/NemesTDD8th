using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain.Tests
{
    [TestFixture]
    public class DomainTestFixture
    {
        [Test]
        public void FirstTest()
        {
            int result = 10 - 5;
            Assert.AreEqual(5, result);
        }
    }
}
