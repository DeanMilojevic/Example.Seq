using System;
using Example.Api.Models;
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

        [HttpGet("exception")]
        public IActionResult Exception()
        {
            try
            {
                throw new System.Exception("This should not happen!");
            }
            catch (System.Exception ex)
            {
                _logger.LogCritical(ex, "This is an exception loggin in the seq!");
            }
            
            return Ok();
        }
        
        [HttpGet("consumer")]
        public IActionResult Consumer()
        {
            var consumer = new Consumer
            {
                FirstName = "first",
                LastName = "last",
                DOB = DateTime.Now
            };

            _logger.LogInformation("This is an object loggin in the seq: {@consumer}", consumer);
            
            return Ok();
        }
    }
}
