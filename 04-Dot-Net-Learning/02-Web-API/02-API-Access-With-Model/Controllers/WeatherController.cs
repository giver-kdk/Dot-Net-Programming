using _02_API_Access_With_Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _02_API_Access_With_Model.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        // Dependency Injection fot HttpClient
        private IHttpClientFactory _httpClientFactory;
        public WeatherController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetWeather()
        {
            var weatherClient = _httpClientFactory.CreateClient("weather");
            string endpoint = "/v1/forecast?";
            string parameters = "latitude=52.52&longitude=13.41&current=temperature_2m,wind_speed_10m&hourly=temperature_2m,relative_humidity_2m,wind_speed_10m";
            string requestURI = endpoint + parameters;

            var response = await weatherClient.GetAsync(requestURI);
            if(response.IsSuccessStatusCode)
            {
                // Converts the API data into JSON format as per JSON Model class
                var result = response.Content.ReadFromJsonAsync<JSONResponseModel>();
                return Ok(result);
            }
            else{
                return BadRequest("Failed to obtain weather data!");
            }
        }
    }
}
