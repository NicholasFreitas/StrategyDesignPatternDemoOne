using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo2.Identity.Profession
{
    class Teacher : IProfession
    {
        public void GetProfession()
        {
            Console.WriteLine("I am a Teacher.");
        }
    }
}
