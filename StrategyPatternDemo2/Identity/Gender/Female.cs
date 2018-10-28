using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo2.Identity.Gender
{
    class Female : IGender
    {
        public void GetGender()
        {
            Console.WriteLine("I am a woman.");
        }
    }
}
