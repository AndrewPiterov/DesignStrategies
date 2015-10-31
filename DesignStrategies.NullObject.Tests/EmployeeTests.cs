using System;
using DesignStrategies.Strategies;
using NUnit.Framework;

namespace DesignStrategies.NullObject.Tests
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void TestNull()
        {
            var e = DB.GetEmployee("no");

            if (e.IsTimeToPay(new DateTime()))
            {
                Assert.Fail();
            }

            Assert.AreSame(EmployeeBase.NULL, e);
        }
    }
}
