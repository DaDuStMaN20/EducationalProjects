// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-07-2022
// ***********************************************************************
// <copyright file="Program.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using InheritanceAndInterfaces.BusinessLogic;
using InheritanceAndInterfaces.Models;
using InheritanceAndInterfaces.Repositories;
using InheritanceAndInterfaces.Services;
using System;
using System.Collections.Generic;

namespace InheritanceAndInterfaces
{
    /// <summary>
    /// Class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nCreating a employee service with a sql database. \n\n\n");

            // Create dependencies
            IEmployeeRepository sqlRepo = new SqlEmployeeRepository();
            IEmployeeBusinessLogic sqlEmployeeBusinessLogic = new EmployeeBusinessLogic(sqlRepo);
            IEmployeeService sqlEmployeeService = new EmployeeService(sqlEmployeeBusinessLogic);

            var sqlAllEmployees = sqlEmployeeService.Get() as List<IEmployee>;
            var sqlNamedEmployee = sqlEmployeeService.GetEmployee("Adam Sanchez");

            Console.WriteLine("\nNamed Employee: \n");

            sqlNamedEmployee.IntroduceYourself();

            Console.WriteLine("Look at all of my employees!");

            // Faking data so we dont have to override generic method.
            sqlAllEmployees.Add(new Employee("TestName1", "The Company 1", 11));
            sqlAllEmployees.Add(new Employee("TestName2", "The Company 1", 1020));
            sqlAllEmployees.Add(new Employee("TestName3", "The Company 2", 104));

            foreach (var employee in sqlAllEmployees)
            {
                employee.IntroduceYourself();
            }

            Console.WriteLine("\n\n Creating a employee service with a mongo database. \n\n\n");

            IEmployeeRepository mongoRepo = new MongoEmployeeRepository();
            IEmployeeBusinessLogic mongoEmployeeBusinessLogic = new EmployeeBusinessLogic(mongoRepo);
            IEmployeeService mongoEmployeeService = new EmployeeService(mongoEmployeeBusinessLogic);

            var mongoAllEmployees = mongoEmployeeService.Get() as List<IEmployee>;
            var mongoNamedEmployee = mongoEmployeeService.GetEmployee("Jason Sanchez");

            Console.WriteLine("\nNamed Employee: \n");

            mongoNamedEmployee.IntroduceYourself();

            Console.WriteLine("Look at all of my employees!");

            // Faking data so we dont have to override generic method.
            mongoAllEmployees.Add(new Employee("TestName1", "The Company 1", 11));
            mongoAllEmployees.Add(new Employee("TestName2", "The Company 1", 1020));
            mongoAllEmployees.Add(new Employee("TestName3", "The Company 2", 104));

            foreach (var employee in mongoAllEmployees)
            {

                employee.IntroduceYourself();

                Console.WriteLine("");
            }

        }
    }
}
