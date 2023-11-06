using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Command.Commands;
using DesignPatterns.Behavioral.Command.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdapterController : ControllerBase
    {
        private readonly IRemoteControl _remoteControl;

        public AdapterController(IRemoteControl remoteControl)
        {
            _remoteControl = remoteControl;
        }

        [HttpPost("/TurnOnLight")]
        public IActionResult Post()
        {
            Light livingRoomLight = new();

            ICommand turnOnCommand = new TurnOnLightCommand(livingRoomLight);

            _remoteControl.Execute(turnOnCommand);

            return Ok();
        }
    }
}
