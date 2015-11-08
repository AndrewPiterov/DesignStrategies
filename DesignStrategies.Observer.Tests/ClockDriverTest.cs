using System;
using NUnit.Framework;

namespace DesignStrategies.Observer.Tests
{
    [TestFixture]
    public class ClockDriverTest
    {
        [Test]
        public void TestTimeChanged()
        {
            var source = new MockTimeSource();
            var sink = new MockTimeSink();
            var driver  = new ClockDriver(source, sink);

            source.SetTime(3, 4, 5);
            Assert.AreEqual(3, sink.GetHours());
            Assert.AreEqual(4, sink.GetMinutes());
            Assert.AreEqual(5, sink.GetSeconds());

            source.SetTime(6, 7,8);
            Assert.AreEqual(6, sink.GetHours());
            Assert.AreEqual(7, sink.GetMinutes());
            Assert.AreEqual(8, sink.GetSeconds());
        }
    }

    public class MockTimeSink:ITimeSink
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int GetHours()
        {
            return _hours;
        }

        public int GetMinutes()
        {
            return _minutes;
        }

        public int GetSeconds()
        {
            return _seconds;
        }

        public void SetTime(int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }
    }

    public class MockTimeSource:ITimeSource
    {
        private ClockDriver _driver;

        public void SetDriver(ClockDriver driver)
        {
            _driver = driver;
        }

        public void SetTime(int hours, int minutes, int seconds)
        {
            _driver.Update(hours, minutes, seconds);
        }
    }
}
