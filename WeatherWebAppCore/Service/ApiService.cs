using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Constants;
using WeatherWebAppCore.Exceptions;
using WeatherWebAppCore.IService;

using static WeatherWebAppCore.Constants.Units;
using static WeatherWebAppCore.Constants.ApiConstants;

namespace WeatherWebAppCore.Service
{
    public class ApiService : ApiDriver, IApiService
    {
        public ApiService() : base()
        {

        }

        public async Task<T> GetApi<T>(ApiUris apiUris, string city)
        {
            var uri = FabricateUrl(apiUris, city);
            return await GetApi<T>(apiUris, uri);
        }

        private async Task<T> GetApi<T>(ApiUris apiUris, Uri uri)
        {
            try
            {
                T content = await base.GetAsync<T>(uri);

                return content;

            }
            catch (Exception ex)
            {

                throw new ApiException(ex.Message, ex);
            }
        }

        private Uri FabricateUrl(ApiUris apiUris, string args)
        {

            return new Uri($"{API_PROTOCOL}://{API_HOST}/{GetWeatherByCity}{args}&units={Metric}&appid={ApiKey}", UriKind.Absolute);

        }
    }
}
