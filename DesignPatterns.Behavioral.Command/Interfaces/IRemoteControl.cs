namespace DesignPatterns.Behavioral.Command.Interfaces
{
    public interface IRemoteControl
    {
        void Execute(ICommand command);
    }
}
