using Microsoft.AspNetCore.Mvc;

namespace Restaurant.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                         IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecastService.Get();
        }

        [HttpGet]
        [Route("statuscode")]
        public ObjectResult Get([FromQuery] int code)
        {
            // Response.StatusCode = 200;
            return StatusCode(code, _weatherForecastService.Get());
        }

        [HttpGet]
        [Route("{take}/example")]
        public IEnumerable<WeatherForecast> Get([FromQuery] int max, [FromRoute] int take)
        {
            var result = _weatherForecastService.Get();
            return result;
        }

        [HttpPost]
        public string Hello([FromBody] string name)
        {
            return $"Hello {name}";
        }
    }
}
