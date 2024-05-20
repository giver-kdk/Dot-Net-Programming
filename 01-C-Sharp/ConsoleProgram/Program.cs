using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // URL of a API
        string apiUrl = "https://api.openweathermap.org/data/2.5/weather?q=Kathmandu&appid=aafba97f9cdd6225a97072d8297ea264";

        try
        {
            // Perform an asynchronous HTTP GET request
            string result = await FetchDataAsync(apiUrl);

            Console.WriteLine($"Data from API: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static async Task<string> FetchDataAsync(string apiUrl)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            // Send an asynchronous GET request
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

            // Check if the request was successful
            response.EnsureSuccessStatusCode();

            // Read and return the content as a string
            return await response.Content.ReadAsStringAsync();
        }
    }
}
