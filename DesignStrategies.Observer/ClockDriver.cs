namespace DesignStrategies.Observer
{
    public class ClockDriver
    {
        private readonly ITimeSink _sink;

        public ClockDriver(ITimeSource source, ITimeSink sink)
        {
            source.SetDriver(this);
            _sink = sink;
        }

        public void Update(int hours, int minutes, int seconds)
        {
            _sink.SetTime(hours, minutes, seconds);
        }
    }
}
