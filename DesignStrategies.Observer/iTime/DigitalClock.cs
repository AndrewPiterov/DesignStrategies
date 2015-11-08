using DesignStrategies.Observer.Canonical;

namespace DesignStrategies.Observer.iTime
{
    public class DigitalClock : IObserver
    {
        private readonly Clock _clock;
        public int Hours;
        public int Minutes;
        public int Seconds;

        public DigitalClock(Clock clock)
        {
            clock.RegisterObserver(this);
            _clock = clock;
        }

        public void Update()
        {
            Hours = _clock.Hours;
            Minutes = _clock.Minutes;
            Seconds = _clock.Seconds;
        }
    }
}
