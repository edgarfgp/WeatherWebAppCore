﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Constants;

namespace WeatherWebAppCore.IService
{
    public interface IApiService
    {
        Task<T> GetApi<T>(ApiUris apiUris, string city);
    }
}