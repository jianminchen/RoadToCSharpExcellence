using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.Thresholds
{
    class BoilingThresholdDerivedClass : ThresholdAbstractClass
    {
        /// <summary>
        /// message should include <= or LessEqual
        /// </summary>
        /// <param name="message"></param>
        public override void SetSpecifier(string message)
        {
            if (!message.Contains(">= or BiggerEqual"))
            {
                throw new ArgumentException("Please specify using \">= or BiggerEqual\"");
            }

            Specifier = message;
        }

        public override bool PassThreshold(string temperature)
        {
            return TemperatureComparer.BiggerEqual(temperature, ThresholdValue);
        }

        public override void DisplayThreshold(string temperature)
        {
            Console.WriteLine("Boiling note: " + temperature + " " + Specifier + " " + ThresholdValue + ". Super hot!");
        }

        public override bool CheckInRange(string temperature, string threshold, string range)
        {
            return TemperatureComparer.LessEqual(temperature, threshold, range);
        }
    }
}
