namespace TestEFSqLiteOnXamarin.Persistance
{
    public class DbConnection
    {
        private static object syncRoot = new object();
        private static DbConnection instance;

        public static DbConnection Instance
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }

                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new DbConnection();
                    }
                }

                return instance;
            }
        }

        public DatabaseContext DbContext => new DatabaseContext();

        private DbConnection()
        {
        }
    }
}
