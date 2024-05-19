using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _01_Simple_API_Access.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        // Dependency Injection for HttpClient
        private IHttpClientFactory _httpClientFactory;
        public WeatherController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory; 
        }

        // Action method for GET Request on 'api/Weather'
        [HttpGet("")]
        public async Task<IActionResult> GetWeather()
        {
            // Create the Http Client
            var weatherClient = _httpClientFactory.CreateClient("weather");
            // The URL parameters 
            string endpoint = "/v1/forecast?";
            string parameters = "latitude=52.52&longitude=13.41&hourly=temperature_2m";
            string requestURI = endpoint + parameters;
            // Perform 'GET' method request on the final api URL
            var response = await weatherClient.GetAsync(requestURI);
            if(response.IsSuccessStatusCode)                        // Check response status for error handling
            {
                var result = response.Content.ReadAsStringAsync();
                // Return 'OK' status code with result data
                return Ok(result);
            }
            else{
                return BadRequest("Unable to get weather data");
            }
        }
    }
}
