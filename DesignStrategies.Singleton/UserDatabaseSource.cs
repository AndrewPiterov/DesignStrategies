using DesignStrategies.Singleton.Models;

namespace DesignStrategies.Singleton
{
    public class UserDatabaseSource:IUserDatabase
    {
        public static UserDatabaseSource Instance { get; } = new UserDatabaseSource();

        private UserDatabaseSource()
        {
            
        }

        public User ReadUser(string userName)
        {
            // do stuff
            return null;
        }

        public void WriteUser(User user)
        {
            // do stuff
        }
    }
}
