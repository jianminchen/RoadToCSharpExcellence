using case_study_Two.Thresholds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.Themometers
{    
    class ThemometerWithSmartThreshold : ThemometerAbstractClass
    {
        public SmartFreezingThresholdDerivedClass ThresholdSpecified { get; set; }

        // skip insignificant amount flunctuate notification 
        public string InsignificantAmount { get; set; }        

        // handle directional option
        public bool Directionspecified { get; set; }
        public bool DroppingOnly { get; set; }
        public bool AscendingOnly { get; set; }

        /// <summary>
        /// directional - not implemented yet
        /// </summary>
        /// <param name="dataPoints"></param>
        /// <param name="pauseInSeconds"></param>
        /// <param name="displayCelsius"></param>
        /// <param name="displayInformed"></param>
        public override void ReadTemperature(string[] dataPoints, int pauseInSeconds, bool displayCelsius, bool displayInformed)
        {
            if (dataPoints == null || dataPoints.Length == 0 || pauseInSeconds < 0)
                return;

            var length = dataPoints.Length;
            var start = false;
            for (int i = 0; i < length; i++)
            {
                var value = dataPoints[i];
                var split = value.Split(' ');

                var isCelsius = split[1].Contains("C");
                var isFaherenheit = split[1].Contains("F");

                var response = new DisplayForThermometer();
                response.DisplayTemperature(displayCelsius, Convert.ToDecimal(split[0]), isCelsius);

                if ( ThresholdSpecified != null )
                {                  
                    // display threshold                    
                    var passed      = ThresholdSpecified.PassThreshold(value);
                    var threshold   = ThresholdSpecified.ThresholdValue;
                    var insignificant = ThresholdSpecified.CheckInRange(value, threshold, InsignificantAmount);
                    var directionalCheck =
                        // n/a      not specified          specified and          dropping       current temperature lower than previous
                        i == 0 || !Directionspecified || (Directionspecified && DroppingOnly && Convert.ToDouble(split[0]) < Convert.ToDouble(dataPoints[i - 1].Split(' ')[0]));

                    // directional passes       reach threshold        alreay in threshold  significant flunctuate
                    if( directionalCheck   && ((!start && passed ) || (start && passed && !insignificant)))
                    {
                        ThresholdSpecified.DisplayThreshold(value);
                        start = true;
                    }
                    else if(start && !passed && !insignificant)
                    {
                        start = false;
                    }                                                          
                }                
                
                System.Threading.Thread.Sleep(pauseInSeconds);
            }
        }
    }
}
