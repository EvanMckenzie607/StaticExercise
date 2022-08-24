using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double farenheitTemp)
        {
            var convertF = (farenheitTemp - 32) / 1.8;
            var tempRounded = Math.Round(convertF, 2);
            return tempRounded;
        }
        public static double CelsiusToFarenheit(double celsiusTemp)
        {
            var convertC = (celsiusTemp * 9) / 5 + 32;
            var tempRounded = Math.Round(convertC, 2);
            return tempRounded;
        }
    }

}
