using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.IService;
using WeatherWebAppCore.Model;

namespace WeatherWebAppCore.Service
{
    public class MockWeatherService : IWeatherService
    {
        public Task<WeatherObject> GetWeatherByLocation(string city)
        {
            return null;
        }

        public IEnumerable<WeatherObject> MockGetWeatherByLocation()
        {
            return new List<WeatherObject>
            {
                new WeatherObject {
                    Name = "Madrid",
                    Base = "Spain",
                    Main = new Main { Humidity = 20, Pressure = 10, Temp = 45, TempMax = 14, TempMin = 21 }
                },
                 new WeatherObject {
                    Name = "London",
                    Base = "UK",
                    Main = new Main { Humidity = 20, Pressure = 10, Temp = 45, TempMax = 14, TempMin = 21 }
                }
            };



        }
    }
}
