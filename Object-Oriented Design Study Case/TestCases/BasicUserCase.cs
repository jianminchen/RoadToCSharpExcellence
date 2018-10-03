using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.TestCases
{
    /// <summary>
    /// Themometer basic read and dispaly functionality
    /// Demonstrate the function to read a list of temperature and then display one by one
    /// based on specified format: Celsius or Faherenheit
    /// Each temperature will show on console output and pause specified seconds. 
    /// No information followed such as freezing or boiling etc. 
    /// </summary>
    public class BasicUserCase
    {
        /// <summary>
        /// the test case will cover basic feature: 
        /// read the temperature of some external source, and then display the result
        /// </summary>
        public static void Run()
        {
            runTestcase1();
            runTestcase2();
        }

        private static void runTestcase1()
        {
            var defaultOne = new Themometer();

            var dataPoints = new string[] { "1.5 C", "1.0 C", "0.5 C", "0.0 C" };

            var pauseInSeconds = 1;
            var displayCelsius = false;

            defaultOne.ReadTemperature(dataPoints, pauseInSeconds, displayCelsius, false);
            defaultOne.ReadTemperature(dataPoints, pauseInSeconds, true, false);
        }

        private static void runTestcase2()
        {
            var defaultOne = new Themometer();

            var dataPoints = new string[] { "35 °F", "36 °F", "37 °F", "38 °F" };

            var pauseInSeconds = 1;
            var displayCelsius = false;

            defaultOne.ReadTemperature(dataPoints, pauseInSeconds, displayCelsius, false);
            defaultOne.ReadTemperature(dataPoints, pauseInSeconds, true, false);
        }
    }
}
