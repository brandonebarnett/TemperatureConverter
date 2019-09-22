﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class TemperatureConverter
    {
        public static double FahrenheitToCelsius(string tempFahrenheit)
        {
            double fahrenheit = double.Parse(tempFahrenheit);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

        public static double CelsiusToFahrenheit(string tempCelsius)
        {
            double celsius = double.Parse(tempCelsius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}
