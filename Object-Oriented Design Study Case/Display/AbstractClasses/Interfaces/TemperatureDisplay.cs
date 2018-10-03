using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.Display.Interfaces
{
    interface ITemperatureDisplay
    {
        void DisplayTemperature(bool displayCelsius, decimal temperature, bool isCelsius);
    }
}
