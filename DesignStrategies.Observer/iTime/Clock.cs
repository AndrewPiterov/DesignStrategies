using DesignStrategies.Observer.Canonical;

namespace DesignStrategies.Observer.iTime
{
    public class Clock : Subject
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public void SetTime(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;

            NotifyObservers();
        }
    }
}
