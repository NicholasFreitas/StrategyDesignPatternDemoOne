using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo2.Identity.Sex
{
    class Intersex : ISex
    {
        public void GetSex()
        {
            Console.WriteLine("I am intersex.");
        }
    }
}
