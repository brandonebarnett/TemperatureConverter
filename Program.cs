using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = string.Empty;
            while (choice != "q" && choice != "Q")
            {
                Console.Write("Enter C) Celcius, F) Fahrenheit or Q) to quit.");
                choice = Console.ReadLine();
                double fahrenheit = 0;
                double celsius = 0;

                switch(choice)
                {
                    case "C":
                    case "c":
                        Console.Write("Please enter the temperature in Celsius: ");
                        fahrenheit = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                        Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheit:f2}");
                        break;
                    case "F":
                    case "f":
                        Console.Write("Please enter the temperature in Fahrenheit: ");
                        celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"The temperature in Celsius is: {celsius:f2}");
                        break;
                    case "Q":
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Please try again.");
                        break;
                }
            }
        }
    }
}
