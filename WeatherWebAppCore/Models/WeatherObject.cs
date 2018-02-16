using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WeatherWebAppCore.Models
{
    public class City
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }
    public class Day
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tempMaxMin")]
        public string TempMaxMin { get; set; }

        [JsonProperty("cityId")]
        public string CityId { get; set; }
    }

}

