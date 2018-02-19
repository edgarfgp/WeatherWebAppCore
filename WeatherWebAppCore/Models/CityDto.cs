using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebAppCore.Models
{
    public class CityDto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Country name is required")]
        public string Country { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "City name is required")]
        public string CityName { get; set; }

    }
}
