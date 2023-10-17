using DesignPatterns.Creational.Singleton;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        private readonly ISingletonClass _singletonClass;

        public SingletonController(ISingletonClass singletonClass)
        {
            _singletonClass = singletonClass;
        }

        [HttpGet("/GetSameIdEveryTime1")]
        public IActionResult GetDependecyInjected()
        {
            return Ok(_singletonClass.GetId());
        }

        [HttpGet("/GetSameIdEveryTime2")]
        public IActionResult GetByUniqueInstance()
        {
            var singleton = AnotherSingeltonClass.Instance;

            return Ok(singleton.GetId());
        }
    }
}
