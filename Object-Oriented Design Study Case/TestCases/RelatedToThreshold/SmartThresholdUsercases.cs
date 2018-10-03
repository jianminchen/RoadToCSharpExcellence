using case_study_Two.Themometers;
using case_study_Two.Thresholds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.TestCases.RelatedToThreshold
{
    class SmartThresholdUsercases
    {
        /// <summary>
        /// The directional is not specified, so the last temperature -10 C
        /// will trigger the notification
        /// </summary>
        public static void RunSmartFreezingThresholdTest()
        {
            var myThemometer = new ThemometerWithSmartThreshold();
            // ignore insignificant flunctuation
            myThemometer.InsignificantAmount = "+/- 0.5 °C";
            
            // directional specified for dropping
            myThemometer.Directionspecified = false;
            myThemometer.DroppingOnly = false;
            myThemometer.AscendingOnly = false;

            var threshold = new SmartFreezingThresholdDerivedClass();

            threshold.SetValue("0 C");
            threshold.SetSpecifier("<= or LessEqual");

            myThemometer.ThresholdSpecified = threshold;
            var dataPoints = new string[] { "1.5 C", "1.0 C", "0.5 C", "0.0 C", "-0.5 C", "0.0 C", "-20 C","-10 C"};

            var pauseInSeconds = 1;
            var displayCelsius = true;
            var displayInfo = true;

            myThemometer.ReadTemperature(dataPoints, pauseInSeconds, displayCelsius, displayInfo);
        }

        /// <summary>
        /// The directional is specified to check dropping only, so the last temperature "-10 C"
        /// will not trigger the notification since it ascends from the previous value. 
        /// </summary>
        public static void RunSmartFreezingThresholdTest2()
        {
            Console.WriteLine("\n\n\nThe smart freezing threshold thermometer is tested in the following:");
            Console.WriteLine("Freezing is defined <= or LessEqual 32 F");
            Console.WriteLine("InsignificantAmount: +/- 0.5 °C");
            Console.WriteLine("The direction is specified, Dropping only.");
            Console.WriteLine("So last temperature -10 C will not trigger notification.");
            Console.WriteLine("The smart freezing threshold thermometer is tested in the following:");
            Console.WriteLine("The temperature data points are the following:");
            Console.WriteLine("1.5 C, 1.0 C, 0.5 C, 0.0 C, -0.5 C, 0.0 C, -20 C, -10 C");            

            var myThemometer = new ThemometerWithSmartThreshold();
            // ignore insignificant flunctuation
            myThemometer.InsignificantAmount = "+/- 0.5 °C";

            // directional specified for dropping
            myThemometer.Directionspecified = true;
            myThemometer.DroppingOnly = true;
            myThemometer.AscendingOnly = false;

            var threshold = new SmartFreezingThresholdDerivedClass();

            threshold.SetValue("32 F");  // 0 C -> 32 F
            threshold.SetSpecifier("<= or LessEqual");

            myThemometer.ThresholdSpecified = threshold;
            var dataPoints = new string[] { "1.5 C", "1.0 C", "0.5 C", "0.0 C", "-0.5 C", "0.0 C", "-20 C", "-10 C" };

            var pauseInSeconds = 1;
            var displayCelsius = true;
            var displayInfo = true;

            myThemometer.ReadTemperature(dataPoints, pauseInSeconds, displayCelsius, displayInfo);
        }
    }
}
