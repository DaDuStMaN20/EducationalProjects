using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Employee
    {

        // Fields        
        private string _name;

        private string _company;

        // Properties 
        public string Name
        {
            get => _name;
            set
            {
                if (value.ToLower().Equals("alex"))
                {
                    _name = "It";
                    return;
                }
                
                _name = value;
                
            }
        }

        public string Company { get; set; }

        public int Age { get; set; }

        public Employee(string name, string company, int age)
        {
            this._name = name;
            Company = company;
            Age = age;
        }

        public Employee()
        {
            _name = "";
            Company = "";
            Age = 0;
        }

        public void IntroduceYourself()
        {

            Console.WriteLine($"Name - {_name}");
            Console.WriteLine($"Company - {Company}");
            Console.WriteLine($"Age - {Age}");

        }

        public string GetCompany()
        {
            return _company;
        }

        public void SetCompany(string company)
        {
            _company = company;
        }
    }
}
