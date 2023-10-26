using DesignPatterns.Structural.Adapter.Interfaces;

namespace DesignPatterns.Structural.Adapter
{
    public class LegacyLibrary : ILegacyLibrary
    {
        public string DoSomethingOld()
        {
            return "LegacyLibrary is doing something old.";
        }
    }
}
