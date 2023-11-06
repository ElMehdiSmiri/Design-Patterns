using DesignPatterns.Structural.Facade.SubSystems;

namespace DesignPatterns.Structural.Facade
{
    public class ComputerFacade : IComputerFacade
    {
        public string StartComputer()
        {
            Console.WriteLine("Computer is starting up...");
            Memory.LoadData();
            HardDrive.ReadData();
            CPU.ProcessData();
            Console.WriteLine("Computer is ready to use.");

            return "Computer is ready to use.";
        }
    }
}
