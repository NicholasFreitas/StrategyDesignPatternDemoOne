using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo2.Identity.Ethnicity
{
    class EgyptianEthnicity : IEthnicity
    {
        public void GetAncestry()
        {
            Console.WriteLine("My ancestors are Egyptian.");
        }
    }
}
