using Microsoft.VisualStudio.TestTools.UnitTesting;
using KOAE.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOAE.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {

        [TestMethod()]
        public void CelsiusToFahrenheit_ConvierteCorrectamente()
        {
            TemperatureConverter _converter = new TemperatureConverter();

            // Arrange
            double celsius = 0;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(32, resultado);
        }

        [TestMethod()]
        public void CelsiusToFahrenheit_ConvierteCorrectamente_ValoresNegativos()
        {
            TemperatureConverter _converter = new TemperatureConverter();

            // Arrange
            double celsius = -40;

            // Act
            double resultado = _converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(-40, resultado);
        }

        [TestMethod()]
        public void FahrenheitToCelsius_ConvierteCorrectamente()
        {
            TemperatureConverter _converter = new TemperatureConverter();

            // Arrange
            double fahrenheit = 32;

            // Act
            double resultado = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(0, resultado);
        }

        [TestMethod()]
        public void FahrenheitToCelsius_ConvierteCorrectamente_ValoresNegativos()
        {
            TemperatureConverter _converter = new TemperatureConverter();

            // Arrange
            double fahrenheit = -40;

            // Act
            double resultado = _converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(-40, resultado);
        }
    }
}