using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two
{
    class TemperatureComparer
    {
        /// <summary>
        /// symbol should be 'F' or 'C'
        /// </summary>
        /// <param name="value"></param>
        /// <param name="threshold"></param>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static bool LessEqual(string value, string threshold)
        {
            if (!checkTemperatureFormat(value) || ! checkTemperatureFormat(threshold))
                return false;

            return Convert.ToDouble(TemperatureComparer.ToCelsius(value)) <= Convert.ToDouble(TemperatureComparer.ToCelsius(threshold));
        }
        
        public static bool BiggerEqual(string value, string threshold)
        {
            if (!checkTemperatureFormat(value) || !checkTemperatureFormat(threshold))
                return false;

            return Convert.ToDouble(TemperatureComparer.ToCelsius(value)) >= Convert.ToDouble(TemperatureComparer.ToCelsius(threshold));
        }

        public static bool LessEqual(string value, string threshold, string range)
        {
            if (!checkTemperatureFormat(value)     || 
                !checkTemperatureFormat(threshold) ||
                failToPassTemperatureFormat(range))
                return false;

            var valueInCelsius = Convert.ToDouble(TemperatureComparer.ToCelsius(value));
            var thresholdInCelsius = Convert.ToDouble(TemperatureComparer.ToCelsius(threshold));

            // ignore +/-, or +, or - three possible options right now. 
            var rangeTemeprature = range.Split(' ')[1] + " " + range.Split(' ')[2];
            var rangeInCelsius = Convert.ToDouble(TemperatureComparer.ToCelsius(rangeTemeprature));

            return Math.Abs(valueInCelsius - thresholdInCelsius) <= Math.Abs(rangeInCelsius);
        }
       
        /// <summary>
        /// temperature format: 
        /// 5 C
        /// 38 F
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static bool checkTemperatureFormat(string value)
        {
            return (value == null || value.Split(' ').Length < 2 || 
                (value.Split(' ')[1].Contains("C") || value.Split(' ')[1].Contains("F")));                            
        }

        private static bool failToPassTemperatureFormat(string value)
        {
            return (value == null || value.Split(' ').Length < 3 ||
                // missing C and F
               (! (value.Split(' ')[2].Contains("C") || value.Split(' ')[2].Contains("F"))));
        }

        private static string ToCelsius(string value)
        {
            var split = value.Split(' ');
            if (value.Contains("C"))
            {
                return split[0];
            }
            else
            {
                var item = new Faherenheit(Convert.ToDecimal(split[0]));
                return item.ToCelsius().ToString();
            }
        }
    }
}
