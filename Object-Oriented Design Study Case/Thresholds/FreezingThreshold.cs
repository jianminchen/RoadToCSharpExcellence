using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two
{
    class FreezingThresholdDerivedClass : ThresholdAbstractClass
    {
        /// <summary>
        /// message should include <= or LessEqual
        /// </summary>
        /// <param name="message"></param>
        public override void SetSpecifier(string message)
        {
            if (!message.Contains("<= or LessEqual"))
            {
                throw new ArgumentException("Please specify using \"<= or LessEqual\"");
            }

            Specifier = message;
        }

        public override bool PassThreshold(string temperature)
        {
            return TemperatureComparer.LessEqual(temperature, ThresholdValue);
        }

        public override void DisplayThreshold(string temperature)
        {
            Console.WriteLine("Freezing note: " + temperature + " " + Specifier + " " + ThresholdValue + ". Keep warm. It is freezing!");
        }

        public override bool CheckInRange(string temperature, string threshold, string range)
        {
            return TemperatureComparer.LessEqual(temperature, threshold, range);
        }
    }
}
