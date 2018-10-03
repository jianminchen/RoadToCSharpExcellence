using case_study_Two.Display.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.Display
{
    abstract class TemperatureDisplayAbstractClass
    {        
        /// <summary>
        /// The thermometer needs to be able to provide temperature in both Fahrenheit and
        /// Celsius
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="isCelsius"></param>
        public void displayTemperatureFaherenheit(decimal temperature, bool isCelsius)
        {
            var converted = temperature;
            if (isCelsius)
            {
                var item = new Celsius(temperature);
                converted = item.ToFaherenheit();
            }

            showFaherenheit(converted.ToString("0.#"));
        }

        public void displayTemperatureCelsius(decimal temperature, bool isCelsius)
        {
            var converted = temperature;
            if (!isCelsius)
            {
                var item = new Faherenheit(temperature);
                converted = item.ToCelsius();
            }

            showCelsius(converted.ToString("0.#"));
        }

        void showFaherenheit(string value)
        {
            Console.WriteLine("Temperature is " + value + " °F");
        }

        void showCelsius(string value)
        {
            Console.WriteLine("Temperature is " + value + " °C");
        }
    }
}
