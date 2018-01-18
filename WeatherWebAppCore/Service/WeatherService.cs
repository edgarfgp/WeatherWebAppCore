using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Constants;
using WeatherWebAppCore.IService;
using WeatherWebAppCore.Model;

namespace WeatherWebAppCore.Service
{
    public class WeatherService : IWeatherService
    {
        private ApiService _apiService;

        public WeatherService()
        {
            _apiService = new ApiService();
        }

        async Task<WeatherObject> IWeatherService.GetWeatherByLocation(string city)
        {
            try
            {

                return await _apiService.GetApi<WeatherObject>(ApiUris.WeatherByCity_GET, city);
            }
            catch (Exception cex)
            {

                throw cex;
            }
        }
    }
}
