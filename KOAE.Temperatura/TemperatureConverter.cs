using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOAE.Temperatura
{
    public class TemperatureConverter
    {
        // convierte Celsius a Fahrenheit
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }

        // convierte Fahrenheit a Celsius
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
