using DesignPatterns.Structural.Adapter.Interfaces;

namespace DesignPatterns.Structural.Adapter
{
    public class LegacyLibraryAdapter : IModernLibrary
    {
        private readonly ILegacyLibrary _legacyLibrary;

        public LegacyLibraryAdapter(ILegacyLibrary legacyLibrary)
        {
            _legacyLibrary = legacyLibrary;
        }

        public string DoSomethingNew()
        {
            return _legacyLibrary.DoSomethingOld();
        }
    }
}
