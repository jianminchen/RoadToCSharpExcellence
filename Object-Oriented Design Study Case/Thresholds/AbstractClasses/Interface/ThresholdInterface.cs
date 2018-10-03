using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_study_Two.Thresholds.AbstractClasses
{
    interface IThreshold
    {
        // "<= or LessEqual", freezing can be specified. 
        void SetSpecifier(string message);

        // For example, freezing O C, boiling 38 C
        bool PassThreshold(string temperature);
    }
}
