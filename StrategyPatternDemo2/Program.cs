using System;
using StrategyPatternDemo2.People;

namespace StrategyPatternDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person(
                "Abdel"
                ,"Ramda"
                ,34
                ,new Identity.Culture.EgyptianCulture()
                ,new Identity.Ethnicity.EgyptianEthnicity()
                ,new Identity.Gender.Male()
                ,new Identity.Profession.Teacher()
                ,new Identity.Sex.Male());


            person1.GetFirstName(); 
            person1.GetCulture();
            person1.GetProfession();
            person1.GetGender();
            person1.GetSex();
            person1.GetAge();
            person1.GetEthnicity();
            Console.ReadLine();

        }
    }
}
