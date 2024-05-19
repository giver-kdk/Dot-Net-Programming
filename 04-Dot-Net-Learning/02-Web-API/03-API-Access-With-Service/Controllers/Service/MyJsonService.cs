using _03_API_Access_With_Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_API_Access_With_Service.Controllers.Service
{
    // Simply use the service to convert the API resposne into JSON Format
    public class MyJsonService
    {
        // Inject the HttpClient for performing API Request. The HttpClient in injected from Program.cs
        private HttpClient _httpClient;
        public MyJsonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        // The Service returns data of type 'JSONResponseModel' asynchronously
        public async Task<JSONResponseModel?> GetAsyncWeather()
        {
            // Try-Catch the API request
            try{
                string endpoint = "/v1/forecast?";
                string parameters = "latitude=52.52&longitude=13.41&current=temperature_2m,wind_speed_10m&hourly=temperature_2m,relative_humidity_2m,wind_speed_10m";
                string requestURI = endpoint + parameters;
                // Directly get the API JSON result from HttpClient 
                var res = await _httpClient.GetFromJsonAsync<JSONResponseModel>(requestURI);
                return res;
            }
            catch (Exception ex) {
                JSONResponseModel errResponse = null;
                return errResponse;
            }
        }
    }
}
