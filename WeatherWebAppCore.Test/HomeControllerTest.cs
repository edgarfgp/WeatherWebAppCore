using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using WeatherWebAppCore.Controllers;
using WeatherWebAppCore.IService;
using WeatherWebAppCore.Model;

namespace WeatherWebAppCore.Test
{
    [TestClass]
    public class HomeControllerTest
    {

        private IWeatherService weatherService;

        [TestInitialize]
        public void Setup(IWeatherService weatherService)
        {
            this.weatherService = weatherService;


        }

        [TestMethod]
        public void HomeControllerIndex()
        {
            var expected = weatherService.MockGetWeatherByLocation();

            
            
        }
    }
}
