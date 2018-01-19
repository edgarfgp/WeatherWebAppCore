using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherWebAppCore.IService;
using WeatherWebAppCore.Model;

namespace WeatherWebAppCore.Test.Services
{
    [TestClass]
    public class WeatherServiceTest
    {
        private Mock<IWeatherService> mockWeatherService;
        private WeatherObject weatherObject;


        [TestInitialize]
        public void Setup()
        {
            mockWeatherService = new Mock<IWeatherService>();
            weatherObject = new WeatherObject
            {
                Name = "Madrid",
                Clouds = new Clouds { All = 20 },
                Main = new Main { Humidity = 20, Pressure = 12, Temp = 25, TempMax = 25, TempMin = 45 },
                Coord = new Coord { Lat = 12, Lon = 25 },
                Base = "Base",
                Cod = 45,
                Dt = 45,
                Id = 47,
                Sys = new Sys { Country = "Spain", Id = 15, Message = 25, Sunrise = 45, Sunset = 47, Type = 14 },
                Visibility = 58,

            };

        }
       
        [TestMethod]
        public void WeatherService_GetWeatherByLocation_ReturnWeather()
        {
            mockWeatherService.Setup(e => e.GetWeatherByLocation(It.IsAny<string>())).Returns(Task.FromResult(weatherObject));
            mockWeatherService.Verify();
            Assert.AreEqual(weatherObject.Name, "Madrid");
        }

    }

}

