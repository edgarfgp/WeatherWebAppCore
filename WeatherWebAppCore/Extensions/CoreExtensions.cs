using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebAppCore.Extensions
{
    public static class CoreExtensions
    {

        public static Task ToTaskRun(this Task me)
        {
            return Task.Run(async () => { await me; });
        }

        public static void DisplayAlert(this string message, string title = null)
        {
           
        }
    }
}
