using System;

namespace StrategyPatternDemo2.People
{
    public class Person
    {
        string FirstName;
        string LastName;
        int Age;
        Identity.Culture.ICulture Culture;
        Identity.Ethnicity.IEthnicity Ethnicity;
        Identity.Sex.ISex Sex;
        Identity.Gender.IGender Gender;
        Identity.Profession.IProfession Profession;

        public Person(
            string fn
            , string ln
            , int age
            , Identity.Culture.ICulture cult
            , Identity.Ethnicity.IEthnicity eth
            , Identity.Gender.IGender gen
            , Identity.Profession.IProfession prof
            , Identity.Sex.ISex sex)
        {
            FirstName = fn;
            LastName = ln;
            Age = age;
            Culture = cult;
            Ethnicity = eth;
            Gender = gen;
            Profession = prof;
            Sex = sex;
        }


        public void GetFirstName()
        {
            Console.WriteLine(FirstName);
        }

        public void GetLastName()
        {
            Console.WriteLine(LastName);
        }

        public void GetAge()
        {
            Console.WriteLine(Age);
        }

        public void GetCulture()
        {
            Culture.GetCulture();
        }

        public void GetEthnicity()
        {
            Ethnicity.GetAncestry();
        }

        public void GetGender()
        {
            Gender.GetGender();
        }

        public void GetSex()
        {
            Sex.GetSex();
        }

        public void GetProfession()
        {
            Profession.GetProfession();
        }

    }
}
