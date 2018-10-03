using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.Thresholds.AbstractClasses.Interfaces
{
    /// <summary>
    /// Readable is required for thermometer. In order for user to understand, 
    /// display is added to console output before next read. 
    /// dataPoints - temperature of some external source - array of data points
    /// pauseInSeconds - between any two reads, let the program sleep for 1 second to show
    /// the reading result. 
    /// displayCelsius - the display can be in two format, either in Celsius or in Faherenheit
    /// extraInfo - configure yes/ no to show freezing or boiling notification
    /// </summary>
    interface InterfaceReadable
    {
        void ReadTemperature(string[] dataPoints, int pauseInSeconds, bool displayCelsius, bool extraInfo = false);
    }
}
