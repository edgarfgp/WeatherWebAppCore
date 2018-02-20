using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Constants;
using WeatherWebAppCore.Extensions;
using WeatherWebAppCore.IService;
using WeatherWebAppCore.Models;
using WeatherWebAppCore.ViewModels;

namespace WeatherWebAppCore.Controllers
{
    public class HomeController : Controller
    {
        private IWeatherService weatherService;
        private IMemoryCache memoryCache;

        private ILogger<HomeController> logger;

        public HomeController(IWeatherService weatherService, IMemoryCache memoryCache, ILogger<HomeController> logger)
        {
            this.weatherService = weatherService;
            this.memoryCache = memoryCache;
            this.logger = logger;


        }
        [HttpGet()]
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Home";
            var cacheKey = "cities";
            if (memoryCache.TryGetValue(cacheKey, out HomeViewModel homeViewModel))
            {
                homeViewModel.Message = "THE CACHE IS ACTIVE";
                return View(homeViewModel);
            }
            else
            {
                var citiesFromApi = await weatherService.GetCities();
                homeViewModel = new HomeViewModel
                {

                    Title = "Countries",
                    Message = "THE CACHE IS EXPIRED",
                    Cities = citiesFromApi

                };

                memoryCache.Set(cacheKey, homeViewModel, new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(DateTimeOffset.Now.AddSeconds(5)));
                return View(homeViewModel);
            }

        }

        public async Task<IActionResult> Details(Guid id)
        {
            var city = await weatherService.GetCityById(id);

            if (city == null)
            {
                return NotFound();
            }

            var detailViewModel = new DetailViewModel
            {
                CityDetail = city
            };

            return View(detailViewModel);

        }




    }
}
