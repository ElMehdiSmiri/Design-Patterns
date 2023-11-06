using DesignPatterns.Structural.Adapter.Interfaces;
using DesignPatterns.Structural.Facade;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FacadeController : ControllerBase
    {
        private readonly IComputerFacade _computerFacade;

        public FacadeController(IComputerFacade computerFacade)
        {
            _computerFacade = computerFacade;
        }

        [HttpGet("/StartComputer")]
        public IActionResult Get()
        {
            return Ok(_computerFacade.StartComputer());
        }
    }
}
