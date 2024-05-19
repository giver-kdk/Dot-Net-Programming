using _03_API_Access_With_Service.Controllers.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _03_API_Access_With_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        // Inject custom API request service 
        private MyJsonService _jsonService;
        public WeatherController(MyJsonService jsonService)
        {
            _jsonService = jsonService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetWeather()
        {
            // Simply call the injected service method 
            var result = await _jsonService.GetAsyncWeather();
            return Ok(result);
        }
    }
}
