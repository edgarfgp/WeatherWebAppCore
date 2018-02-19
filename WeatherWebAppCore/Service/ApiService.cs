using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Constants;
using WeatherWebAppCore.IService;

using static WeatherWebAppCore.Constants.ApiConstants;
using WeatherWebAppCore.Models;
using System.Net.Http;
using System.Diagnostics;
using Newtonsoft.Json;

namespace WeatherWebAppCore.Service
{
    public class ApiService : IApiService
    {
       

        public async Task<List<T>> GetApi<T>()
        {

            try
            {

                using (HttpClient client = new HttpClient())
                {
                    Debug.WriteLine($">>> Get {ApiConstants.API_URL} ");
                    var response = await client.GetAsync(ApiConstants.API_URL);
                    Debug.WriteLine($"<<< Get {ApiConstants.API_URL} ");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<List<T>>(content);
                        return result;


                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

       

    }
}
