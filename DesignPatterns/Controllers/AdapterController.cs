using DesignPatterns.Structural.Adapter.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdapterController : ControllerBase
    {
        private readonly IModernLibrary _modernLibrary;

        public AdapterController(IModernLibrary modernLibrary)
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
