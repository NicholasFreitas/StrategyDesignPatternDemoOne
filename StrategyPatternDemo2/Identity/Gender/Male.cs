using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo2.Identity.Gender
{
    class Male : IGender
    {
        public void GetGender()
        {
            Console.WriteLine("I am a man.");
        }
    }
}
