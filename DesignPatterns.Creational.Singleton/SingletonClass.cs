namespace DesignPatterns.Creational.Singleton
{
    public class SingletonClass : ISingletonClass
    {
        private readonly Guid _id = Guid.NewGuid();

        public Guid GetId()
        {
            return _id;
        }
    }
}