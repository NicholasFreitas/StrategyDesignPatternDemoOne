﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternDemo2.Identity.Culture
{
    class EgyptianCulture : ICulture
    {
        public void GetCulture()
        {
            Console.WriteLine("I was raised in a traditional Egyptian family.");
        }
    }
}
