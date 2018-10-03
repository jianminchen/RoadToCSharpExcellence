using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two
{
    class Faherenheit
    {
        public decimal Temperature { get; set; }
        public Faherenheit(decimal value)
        {
            Temperature = value;
        }

        /// <summary>
        /// https://www.rapidtables.com/convert/temperature/fahrenheit-to-celsius.html
        /// </summary>
        /// <returns></returns>
        public decimal ToCelsius()
        {
            //(T(°F) - 32) × 5/9                
            return (Temperature - 32) * 5 / 9;
        }
    }
}
