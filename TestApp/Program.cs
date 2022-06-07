using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Saldina";
            employee1.Company = "YT-CodeBeauty";
            employee1.Age = 25;
            employee1.IntroduceYourself();

            Employee employee2 = new Employee();
            employee2.Name = "AleX";
            employee2.Company = "YT-CodeUgly";
            employee2.Age = 255;
            employee2.IntroduceYourself();
        }
    }

}
