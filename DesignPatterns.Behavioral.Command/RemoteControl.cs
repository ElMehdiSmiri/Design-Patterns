using DesignPatterns.Behavioral.Command.Interfaces;

namespace DesignPatterns.Behavioral.Command
{
    public class RemoteControl : IRemoteControl
    {
        public void Execute(ICommand command)
        {
            command.Execute();
        }
    }
}
