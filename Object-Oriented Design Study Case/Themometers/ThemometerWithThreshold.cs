using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two
{
    class ThemometerWithThreshold : ThemometerAbstractClass
    {
        public ThresholdAbstractClass ThresholdSpecified { get; set; }

        public override void ReadTemperature(string[] dataPoints, int pauseInSeconds, bool displayCelsius, bool displayInformed)
        {
            if (dataPoints == null || dataPoints.Length == 0 || pauseInSeconds < 0)
                return;

            var length = dataPoints.Length;
            for (int i = 0; i < length; i++)
            {
                var value = dataPoints[i];
                var split = value.Split(' ');

                var isCelsius = split[1].Contains("C");
                var isFaherenheit = split[1].Contains("F");

                var response = new DisplayForThermometer();
                response.DisplayTemperature(displayCelsius, Convert.ToDecimal(split[0]), isCelsius);

                if (ThresholdSpecified != null && ThresholdSpecified.PassThreshold(value))
                {
                    ThresholdSpecified.DisplayThreshold(value);
                }

                System.Threading.Thread.Sleep(pauseInSeconds);
            }
        }
    }
}
