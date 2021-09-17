using GameStore.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Cliente> Get()
        {
            var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
            var faker = new Bogus.Faker<Cliente>()
                    .RuleFor(x => x.Id, f => f.IndexVariable++)
                    .RuleFor(x => x.Nombre, f => f.Person.FirstName)
                    .RuleFor(x => x.Apellido, f => f.Person.LastName)
                    .RuleFor(x => x.NombreCompleto, f => f.Person.FullName)
                    .RuleFor(x => x.Email, f => f.Person.Email)
                    .RuleFor(x => x.Telefono, f => f.Person.Phone)
                    .RuleFor(x => x.Nacimiento, f => f.Person.DateOfBirth)
                    .RuleFor(x => x.Nit, f => f.Random.Number(100000000, 999999999).ToString())
                    .RuleFor(x => x.CreatedAt, DateTime.Now)
                    .RuleFor(x => x.CreatedBy, "JDLB");

            List<Cliente> list = new List<Cliente>();
            foreach (var p in faker.Generate(11))
                list.Add(p);
            return list;
        }
    }
}
