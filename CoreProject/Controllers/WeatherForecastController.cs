using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contracts.WeatherForecast.Services;
using Core.Data.Context;
using Core.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using transport.WeatherForecast.Request;
using transport.WeatherForecast.Response;

namespace CoreProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private IWeatherForecastAplicationServices _IWeatherForecastAplicationServices;
        public WeatherForecastController(IWeatherForecastAplicationServices IWeatherForecastAplicationServices)
        {
             _IWeatherForecastAplicationServices = IWeatherForecastAplicationServices;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

         

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        [Authorize]
        public async Task<ListadoCategoriaResponse> Post(ListadoCategoriaRequest request)
        {

            var a = await _IWeatherForecastAplicationServices.ListCategory(request.id);

            return a;
        }

    }
}
