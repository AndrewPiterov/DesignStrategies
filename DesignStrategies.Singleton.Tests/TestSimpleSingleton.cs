using System.Linq;
using NUnit.Framework;

namespace DesignStrategies.Singleton.Tests
{
    [TestFixture]
    public class TestSimpleSingleton
    {
        [Test]
        public void TestCreateSingleton()
        {
            var s = SimpleSingleton.Instance;
            var s2 = SimpleSingleton.Instance;

            Assert.AreSame(s, s2);
        }

        [Test]
        public void TestNoPublicConstractor()
        {
            var singleton = typeof (SimpleSingleton);

            var hasPublicConstractor = singleton.GetConstructors().Any(info => info.IsPublic);

            Assert.IsFalse(hasPublicConstractor);
        }
    }
}
