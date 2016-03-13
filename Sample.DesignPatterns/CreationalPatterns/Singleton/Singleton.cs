namespace Sample.DesignPatterns.CreationalPatterns.Singleton
{
    public class Singleton
    {
        static Singleton _instance;

        protected Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            return _instance ?? (_instance = new Singleton());
        }

    }
}