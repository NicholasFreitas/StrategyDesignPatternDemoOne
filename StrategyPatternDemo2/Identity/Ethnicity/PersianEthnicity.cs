using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo2.Identity.Ethnicity
{
    class PersianEthnicity : IEthnicity
    {
        public void GetAncestry()
        {
            Console.WriteLine("I have Persian ancestry.");
        }
    }
}
