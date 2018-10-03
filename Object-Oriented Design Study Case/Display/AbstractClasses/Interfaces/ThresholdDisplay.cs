using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.Display.Interfaces
{
    interface IThresholdDisplay
    {
        /// <summary>
        /// inform the appropriate calls that a specific threshold has been reached. 
        /// </summary>
        /// <param name="temperature"></param>
        void DisplayThreshold(string temperature);
    }
}
