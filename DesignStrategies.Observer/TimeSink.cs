namespace DesignStrategies.Observer
{
    public interface ITimeSink
    {
        void SetTime(int hours, int minutes, int seconds);
    }

    public interface ITimeSource
    {
        void SetDriver(ClockDriver driver);
    }
}
