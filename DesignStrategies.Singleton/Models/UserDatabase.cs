namespace DesignStrategies.Singleton.Models
{
    public interface IUserDatabase
    {
        User ReadUser(string userName);
        void WriteUser(User user);
    }
}
