using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo2.Identity.Culture
{
    class GreekCulture : ICulture
    {
        public void GetCulture()
        {
            Console.WriteLine("I was raised in a traditional Greek family.");
        }
    }
}
