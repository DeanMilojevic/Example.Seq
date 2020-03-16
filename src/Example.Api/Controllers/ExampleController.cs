using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Example.Api.Controllers
{
    [ApiController]
    [Route("api/example")]
    public class ExampleController : ControllerBase
    {
        private readonly ILogger<ExampleController> _logger;

        public ExampleController(ILogger<ExampleController> logger) => _logger = logger;

        [HttpGet("info")]
        public IActionResult Info()
        {
            _logger.LogInformation("This is a information in the seq!");
            return Ok();
        }
        
        [HttpGet("warning")]
        public IActionResult Warning()
        {
            _logger.LogWarning("This is a warning in the seq!");
            return Ok();
        }
        
        [HttpGet("critical")]
        public IActionResult Critical()
        {
            _logger.LogCritical("This is a critical in the seq!");
            return Ok();
        }
        
        [HttpGet("error")]
        public IActionResult Error()
        {
            _logger.LogError("This is a error in the seq!");
            return Ok();
        }
    }
}
