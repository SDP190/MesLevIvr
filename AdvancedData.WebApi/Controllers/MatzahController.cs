using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvancedData.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AdvancedData.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatzahController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<MatzahController> _logger;

        public MatzahController(ILogger<MatzahController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult DoSomething()   //<IEnumerable<WeatherForecast>
        // https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-3.1
        {
            var response = new TelegroundResponse
            {
                Goto = 5
                //, todo
            };

            return Ok(response);


            //var rng = new Random();
            //return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55)
            //    //Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray());
        }
    }
}
