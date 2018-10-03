using case_study_Two.Display.Interfaces;
using case_study_Two.Thresholds.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two
{
    abstract class ThresholdAbstractClass : IThreshold, IThresholdDisplay
    {
        public string ThresholdValue { get; set; }
        public string Specifier;

        public abstract void SetSpecifier(string message);
        public abstract bool PassThreshold(string temperature);
        public abstract void DisplayThreshold(string temperature);
        public abstract bool CheckInRange(string temperature, string threshold, string range);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tempeature"></param>
        public void SetValue(string tempeature)
        {
            if (tempeature == null || !(tempeature.Contains("F") || tempeature.Contains("C")))
                throw new ArgumentException("Please enter temperature in the the format like 1.5 C or 35 °F, using space to separate temperature and metric");

            ThresholdValue = tempeature;
        }
    }
}
