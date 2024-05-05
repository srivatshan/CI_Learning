using Microsoft.AspNetCore.Mvc;

namespace WebApi_CI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezin  g", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController()
        {
           
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            List<Test> data = new List<Test>() { new Test { Id = 1, Name = "Sri" } };
            return Ok(data);
        }
    }

    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}