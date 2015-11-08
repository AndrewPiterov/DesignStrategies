using DesignStrategies.Observer.Canonical;
using DesignStrategies.Observer.iTime;

namespace DesignStrategies.Observer.Tests.iTime
{
    public class MockTimeSink : IObserver
    {
        private readonly ITimeSource _source;
        private int _hours;
        private int _minutes;
        private int _seconds;

        public MockTimeSink(ITimeSource source)
        {
            _source = source;
        }

        public void Update()
        {
            _hours = _source.GetHours();
            _minutes = _source.GetMinutes();
            _seconds = _source.GetSeconds();
        }

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
    }
}