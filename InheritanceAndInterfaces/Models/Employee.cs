// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="Employee.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaces.Models
{
    /// <summary>
    /// Class Employee.
    /// </summary>
    public class Employee : IEmployee
    {

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>The name of the employee.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the company that the employee works at.
        /// </summary>
        /// <value>The company that the employee works at.</value>
        public string Company { get; set; }

        /// <summary>
        /// Gets or sets the age of the employee.
        /// </summary>
        /// <value>The age of the employee.</value>
        public int Age { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee" /> class.
        /// </summary>
        /// <param name="name">The employee name.</param>
        /// <param name="company">The employee company.</param>
        /// <param name="age">The employee age.</param>
        public Employee(string name, string company, int age)
        {
            Name = name;
            Company = company;
            Age = age;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee" /> class.
        /// </summary>
        public Employee()
        {
            Name = "";
            Company = "";
            Age = 0;
        }

        /// <summary>
        /// Introduces the yourself.
        /// </summary>
        public void IntroduceYourself()
        {
            // Print the employee information to the console
            Console.WriteLine($"Name - {Name}");
            Console.WriteLine($"Company - {Company}");
            Console.WriteLine($"Age - {Age}\n");
        }
    }
}
