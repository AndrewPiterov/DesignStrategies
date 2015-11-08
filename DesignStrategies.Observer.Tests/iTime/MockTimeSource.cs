using DesignStrategies.Observer.Canonical;
using DesignStrategies.Observer.iTime;

namespace DesignStrategies.Observer.Tests.iTime
{
    public class MockTimeSource : Subject, ITimeSource
    {
        private int _seconds;
        private int _minutes;
        private int _hours;

        public void SetTime(int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;

            NotifyObservers();
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