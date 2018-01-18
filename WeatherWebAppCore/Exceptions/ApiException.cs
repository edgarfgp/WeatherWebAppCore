using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebAppCore.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException()
        {

        }
        public ApiException(string message) : base(message)
        {

        }
        public ApiException(string message, Exception innerException) : base(message)
        {

        }
    }
}
