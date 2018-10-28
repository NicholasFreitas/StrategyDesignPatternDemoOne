using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo2.Identity.Sex
{
    class Male : ISex
    {
        public void GetSex()
        {
            Console.WriteLine("I was born a man.");
        }

    }
}
