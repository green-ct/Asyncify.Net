using Microsoft.AspNetCore.Mvc;
using Shared.AsyncRequest.Contracts;

namespace Sample.Controllers
{
    [ApiController]
    [AsyncController(typeof(WeatherForecastController))]
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

        [HttpGet("weathers/{id:guid}/today")]
        [AsyncRequest(nameof(Get))]
        public ActionResult<IEnumerable<WeatherForecast>> Get([FromRoute] Guid id, [FromQuery] string name, [FromQuery] int age)
        {

            Thread.Sleep(TimeSpan.FromSeconds(120));

            return (Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }

        [HttpPost("weathers/{id:guid}/today")]
        [AsyncRequest(nameof(Post))]
        public ActionResult<IEnumerable<WeatherForecast>> Post([FromRoute] Guid id, [FromBody] MyClass name)
        {

            return (Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }

        [HttpPut("weathers/{id:guid}/today")]
        [AsyncRequest(nameof(Put))]
        public ActionResult<IEnumerable<WeatherForecast>> Put([FromRoute] Guid id, [FromBody] MyClass name)
        {

            return (Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }

        [HttpDelete("weathers/{id:guid}/today")]
        [AsyncRequest(nameof(Delete))]
        public ActionResult<IEnumerable<WeatherForecast>> Delete([FromRoute] Guid id)
        {

            return (Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }



        public class MyClass
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
        }
    }
}