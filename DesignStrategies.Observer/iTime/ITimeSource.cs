namespace DesignStrategies.Observer.iTime
{
    public interface ITimeSource
    {
        int GetHours();
        int GetMinutes();
        int GetSeconds();
    }
}