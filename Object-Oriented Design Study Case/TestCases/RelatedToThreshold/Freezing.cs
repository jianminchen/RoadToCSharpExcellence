using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.TestCases
{
    /// <summary>    
    /// </summary>
    public class FreezingUserCases
    {
        /// <summary>
        /// It must be possible for callers of the class(es) to define arbitrary thresholds 
        /// such as freezing and boiling at which the thermometer calls will inform the 
        /// appropriate callers that a specific threshold has been reached.
        /// </summary>
        public static void RunFreezingThresholdTest()
        {
            var myThemometer = new ThemometerWithThreshold();
            var threshold = new FreezingThresholdDerivedClass();
            threshold.SetValue("0 C");
            threshold.SetSpecifier("<= or LessEqual");

            myThemometer.ThresholdSpecified = threshold;
            var dataPoints = new string[] { "3 C", "-1 C", "-2 C", "4 C" };

            var pauseInSeconds = 1;
            var displayCelsius = false;
            var displayInfo = true;

            myThemometer.ReadTemperature(dataPoints, pauseInSeconds, displayCelsius, displayInfo);
        }

        public static void RunFreezingThresholdTest2()
        {
            var myThemometer = new ThemometerWithThreshold();
            var threshold = new FreezingThresholdDerivedClass();
            threshold.SetValue("32 F");  // 0 C -> 32 F
            threshold.SetSpecifier("<= or LessEqual");

            myThemometer.ThresholdSpecified = threshold;
            var dataPoints = new string[] { "3 C", "-1 C", "-2 C", "4 C" };

            var pauseInSeconds = 1;
            var displayCelsius = false;
            var displayInfo = true;

            myThemometer.ReadTemperature(dataPoints, pauseInSeconds, displayCelsius, displayInfo);
        }
    }
}
