using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two
{
    abstract class ThemometerAbstractClass
    {
        public decimal Value { get; set; }
        public bool IsFaherenheit { get; set; }

        public abstract void ReadTemperature(string[] dataPoints, int pauseInSeconds, bool displayCelsius, bool extraInfo = false);
    }
}
