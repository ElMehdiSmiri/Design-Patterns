using DesignPatterns.Behavioral.Command.Interfaces;

namespace DesignPatterns.Behavioral.Command.Commands
{
    public class TurnOffLightCommand : ICommand
    {
        private readonly Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
