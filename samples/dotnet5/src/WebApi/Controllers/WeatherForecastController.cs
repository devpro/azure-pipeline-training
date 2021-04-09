using System;
using System.Collections.Generic;
using System.Linq;
using Dotnet5Sample.WebApi.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dotnet5Sample.WebApi.Controllers
{
    [ApiController]
    [Route("weather-forecast")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] s_summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecastDto> Get()
        {
            _logger.LogInformation("New weather forecast request");

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecastDto
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = s_summaries[rng.Next(s_summaries.Length)]
            })
            .ToArray();
        }
    }
}
