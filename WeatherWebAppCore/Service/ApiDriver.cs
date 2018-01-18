using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherWebAppCore.Exceptions;

namespace WeatherWebAppCore.Service
{
    public class ApiDriver
    {
        public ApiDriver()
        {

        }

        protected async Task<T> GetAsync<T>(Uri WebServiceUrl)
        {
            try
            {
               
                using (HttpClient client = new HttpClient())
                {
                    Debug.WriteLine($">>> Get {WebServiceUrl} ");
                    var response = await client.GetAsync(WebServiceUrl);
                    Debug.WriteLine($"<<< Get {WebServiceUrl} ");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<T>(content);
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

                throw ProcessException(ex);
            }
        }

       

        private Exception ProcessException(Exception ex)
        {
            if (ex is ApiException)
            {
                throw new ApiException(ex.Message, ex);
            }
            else
            {
                throw new ApiException("Issue calling the WeatherService. Check the City name and try again", ex);
            }
        }
    }
}

