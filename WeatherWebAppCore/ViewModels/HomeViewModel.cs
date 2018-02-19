using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Models;

namespace WeatherWebAppCore.ViewModels
{
    public class HomeViewModel
    {
        public string  Title { get; set; }

        public List<City> Cities { get; set; }
    }
}
