namespace DesignStrategies.Singleton
{
    public class SimpleSingleton
    {
        private static SimpleSingleton _instance;

        private SimpleSingleton()
        {
            
        }

        public static SimpleSingleton Instance {
            get { return _instance; }
        }
    }
}
