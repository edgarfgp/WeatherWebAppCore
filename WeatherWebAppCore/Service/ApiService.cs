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
using System.Net.Http.Headers;

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
                    Debug.WriteLine($">>> Get {GET_CITIES} ");
                    var response = await client.GetAsync(GET_CITIES);
                    Debug.WriteLine($"<<< Get {GET_CITIES} ");

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

        public async Task<T> GetApi<T>(Guid id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    Debug.WriteLine($">>> Get {ROOT}/{id} ");
                    var response = await client.GetAsync($"{ROOT}/{id}");
                    Debug.WriteLine($"<<< Get {ROOT}/{id}");

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

                throw ex;
            }
        }

        public async Task<bool> PostAsync<T>(T t)
        {
            try
            {

                var json = JsonConvert.SerializeObject(t);
                HttpContent httpContent = new StringContent(json);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");


                using (HttpClient client = new HttpClient())
                {
                    Debug.WriteLine($">>> Post {POST_CITY} ");
                    var response = await client.PostAsync(POST_CITY, httpContent);
                    Debug.WriteLine($"<<< Post {POST_CITY} ");

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        return true;
                    }
                    else
                    {
                        Debug.WriteLine($"ReasonPhrase: {response.ReasonPhrase}");
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
