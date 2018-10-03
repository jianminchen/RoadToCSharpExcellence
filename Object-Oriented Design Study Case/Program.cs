using case_study_Two.TestCases;
using case_study_Two.TestCases.RelatedToThreshold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_case_study
{
    /// <summary>
    /// Design and implement in C# a thermometer class or classes. 
    /// The task is to read the temperature of some external source 
    /// 
    /// Thermometer
    /// temperature - Fahrenheit and Celsius
    /// Callers of the classes 
    /// define arbitrary thresholds - such as freezing and boiling
    /// inform a specific threshold has been reached
    /// - threshold - do not repeatedly inform
    /// temperature is fluctuated around the threshold point.
    /// Some callers may only want to be informed that temperature has reached 
    /// 0 once because the flunctuations of +/- 0.5C insignificant
    /// Some callers may want it - >
    /// Threshold reached from a certain direction. 
    /// Dropping direction
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// To do:
        /// 1. Remove extra freezing note if specified
        /// 2. Add directional information
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MyTest.RunTestcases();
        }

        internal class MyTest
        {
            public static void RunTestcases()
            {
                BasicUserCase.Run();
                FreezingUserCases.RunFreezingThresholdTest();
                FreezingUserCases.RunFreezingThresholdTest2();

                BoilingUsercases.RunBoilingThresholdTest();
                BoilingUsercases.RunBoilingThresholdTest2();

                SmartThresholdUsercases.RunSmartFreezingThresholdTest();
                SmartThresholdUsercases.RunSmartFreezingThresholdTest2();
            }          
        }
    }
}