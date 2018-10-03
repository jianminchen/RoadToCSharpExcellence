using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two
{
    class Celsius
    {
        public decimal Temperature { get; set; }
        public Celsius(decimal value)
        {
            Temperature = value;
        }

        /// <summary>
        /// https://www.rapidtables.com/convert/temperature/celsius-to-fahrenheit.html
        /// </summary>
        /// <returns></returns>
        public decimal ToFaherenheit()
        {
            //T(°C) × 9/5 + 32               
            return Temperature * 9 / 5 + 32;
        }
    }
}
