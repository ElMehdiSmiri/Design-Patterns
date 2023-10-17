namespace DesignPatterns.Creational.Singleton
{
    public sealed class AnotherSingeltonClass
    {
        private readonly Guid _id = Guid.NewGuid();

        private static AnotherSingeltonClass? _instance;

        private static readonly object _lockObject = new();

        private AnotherSingeltonClass()
        {
        }

        public static AnotherSingeltonClass Instance
        {
            get
            {
                if (_instance == null)
                {
                    // Locking to ensure thread safety when multiple threads access this for the first time.
                    lock (_lockObject)
                    {
                        _instance ??= new AnotherSingeltonClass();
                    }
                }
                return _instance;
            }
        }

        public Guid GetId()
        {
            return _id;
        }
    }
}
