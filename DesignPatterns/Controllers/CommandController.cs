using DesignPatterns.Structural.Adapter.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly IModernLibrary _modernLibrary;

        public CommandController(IModernLibrary modernLibrary)
        {
            _modernLibrary = modernLibrary;
        }

        [HttpGet("/DoSomethingNew")]
        public IActionResult Get()
        {
            return Ok(_modernLibrary.DoSomethingNew());
        }
    }
}
