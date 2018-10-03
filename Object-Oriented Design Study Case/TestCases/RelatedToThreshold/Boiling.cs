using case_study_Two.Thresholds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.TestCases.RelatedToThreshold
{
    public class BoilingUsercases
    {
        /// <summary>
        /// It must be possible for callers of the class(es) to define arbitrary thresholds 
        /// such as freezing and boiling at which the thermometer calls will inform the 
        /// appropriate callers that a specific threshold has been reached.
        /// </summary>
        public static void RunBoilingThresholdTest()
        {
            var myThemometer = new ThemometerWithThreshold();
            var threshold = new BoilingThresholdDerivedClass();
            threshold.SetValue("38 C");
            threshold.SetSpecifier(">= or BiggerEqual");

            myThemometer.ThresholdSpecified = threshold;
            var dataPoints = new string[] { "36 C", "37 C", "38 C", "39 C" };

            var pauseInSeconds = 1;
            var displayCelsius = false;
            var displayInfo = true;

            myThemometer.ReadTemperature(dataPoints, pauseInSeconds, displayCelsius, displayInfo);
        }

        public static void RunBoilingThresholdTest2()
        {
            var myThemometer = new ThemometerWithThreshold();
            var threshold = new BoilingThresholdDerivedClass();
            threshold.SetValue("38 C");  // 0 C -> 32 F
            threshold.SetSpecifier(">= or BiggerEqual");

            myThemometer.ThresholdSpecified = threshold;
            var dataPoints = new string[] { "36 C", "37 C", "38 C", "40 C" };

            var pauseInSeconds = 1;
            var displayCelsius = true;
            var displayInfo = true;

            myThemometer.ReadTemperature(dataPoints, pauseInSeconds, displayCelsius, displayInfo);
        }
    }
}
