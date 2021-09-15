using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_pro
{
    class WeatherUtilities
    {
        static public float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) / 1.8f;
        }

        static public float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return temperatureCelsius * 1.8f + 32;
        }
        static public float ComfortIndex(float temperaturefahrenheit, float humidityPercent)
        {
            return (temperaturefahrenheit + humidityPercent) / 4;
        }
        static public void Report(string location, float temperatureCelsius, float humidity)
        {
            float v = CelsiusToFahrenheit(temperatureCelsius);
            var temperatureFahrenheit = v;
            Console.WriteLine($"Comfort Index for{location}:{ComfortIndex(temperatureFahrenheit, humidity)}");
        }
    }

}