using case_study_Two.Display;
using case_study_Two.Display.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two
{
    class DisplayForThermometer : TemperatureDisplayAbstractClass
    {        
        public void DisplayTemperature(bool displayCelsius, decimal temperature, bool isCelsius)
        {
            if (displayCelsius)
            {
                displayTemperatureCelsius(temperature, isCelsius);
            }
            else
            {
                displayTemperatureFaherenheit(temperature, isCelsius);
            }
        }

        
    }
}
