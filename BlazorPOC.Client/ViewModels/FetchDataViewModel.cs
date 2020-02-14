using BlazorPOC.Client.Helpers;
using BlazorPOC.Server;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPOC.Client.ViewModels
{
    public class FetchDataViewModel
    {
        public List<WeatherForecast> WeatherForecasts { get; set; }

        public FetchDataViewModel()
        {
        }

        public async Task GetData()
        {
            var json = await HttpClientHelper.Client.GetStringAsync("api/weatherforecast");

            WeatherForecasts = JsonConvert.DeserializeObject<List<WeatherForecast>>(json);
        }
    }
}