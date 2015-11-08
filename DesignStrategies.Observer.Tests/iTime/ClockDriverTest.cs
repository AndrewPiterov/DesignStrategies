using DesignStrategies.Observer.iTime;
using NUnit.Framework;

namespace DesignStrategies.Observer.Tests.iTime
{
    [TestFixture]
    public class ClockDriverTest
    {
        private Clock _source;
        private DigitalClock _sink;

        [SetUp]
        public void SetUp()
        {
            _source = new Clock();
            _sink = new DigitalClock(_source);
            _source.RegisterObserver(_sink);
        }

        public void TearDown()
        {
            _sink = null;
            _source = null;
        }

        [Test]
        public void TestTimeChanged()
        {
            _source.SetTime(3, 4, 5);
            AssertSinkEquals(_sink, 3, 4, 5);

            _source.SetTime(6, 7, 8);
            AssertSinkEquals(_sink, 6, 7,8);
        }

        [Test]
        public void TestMultiplySinks()
        {
            var sink2 = new DigitalClock(_source);
            _source.RegisterObserver(sink2);

            _source.SetTime(1,2,3);

            AssertSinkEquals(_sink, 1,2,3);
            AssertSinkEquals(sink2, 1, 2, 3);
        }

        private void AssertSinkEquals(DigitalClock sink, int hours, int minutes, int seconds)
        {
            Assert.AreEqual(hours, sink.Hours);
            Assert.AreEqual(minutes, sink.Minutes);
            Assert.AreEqual(seconds, sink.Seconds);
        }
    }
}
