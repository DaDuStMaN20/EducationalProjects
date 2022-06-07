// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-07-2022
// ***********************************************************************
// <copyright file="MongoEmployeeRepository.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using InheritanceAndInterfaces.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaces.Repositories
{
    /// <summary>
    /// Class MongoEmployeeRepository.
    /// Implements the <see cref="InheritanceAndInterfaces.Repositories.MongoRepository{InheritanceAndInterfaces.Models.IEmployee}" />
    /// Implements the <see cref="InheritanceAndInterfaces.Repositories.IEmployeeRepository" />
    /// </summary>
    /// <seealso cref="InheritanceAndInterfaces.Repositories.MongoRepository{InheritanceAndInterfaces.Models.IEmployee}" />
    /// <seealso cref="InheritanceAndInterfaces.Repositories.IEmployeeRepository" />
    public class MongoEmployeeRepository : MongoRepository<IEmployee>, IEmployeeRepository
    {
        /// <summary>
        /// The database connection
        /// </summary>
        private MongoClient _dbConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlEmployeeRepository" /> class.
        /// </summary>
        public MongoEmployeeRepository()
        {
            // initialize _dbConnection
            _dbConnection = new MongoClient();
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IEmployee.</returns>
        public IEmployee GetEmployee(string name)
        {
            Console.WriteLine($"Getting employee from the mongo database. Name: {name}");



            return new Employee(name, "testComp", 8);
        }

        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns>IEnumerable&lt;IEmployee&gt;.</returns>
        public IEnumerable<IEmployee> GetEmployees(string company)
        {

            Console.WriteLine($"Getting employees from the mongo database. Company: {company}");

            var employees = new List<IEmployee>();
            employees.Add(new Employee("TestEmp10", company, 100));
            employees.Add(new Employee("TestEmp20", company, 110));
            employees.Add(new Employee("TestEmp30", company, 120));

            return employees;
        }

        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns>IEnumerable&lt;IEmployee&gt;.</returns>
        public IEnumerable<IEmployee> GetEmployees()
        {
            Console.WriteLine($"Getting employees from the mongo database. All employees");

            // Simulating a successful get.
            var employees = new List<IEmployee>();
            employees.Add(new Employee("TestEmp40", "The Test Company 10", 130));
            employees.Add(new Employee("TestEmp50", "The Test Company 10", 140));
            employees.Add(new Employee("TestEmp60", "The Test Company 20", 150));

            return employees;
        }

        /// <summary>
        /// Inserts the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>IEmployee.</returns>
        public IEmployee InsertEmployee(IEmployee employee)
        {

            // Simulating a successful add.
            return employee;
        }

        /// <summary>
        /// Inserts the employees.
        /// </summary>
        /// <param name="employees">The employees.</param>
        /// <returns>IEnumerable&lt;IEmployee&gt;.</returns>
        public IEnumerable<IEmployee> InsertEmployees(IEnumerable<IEmployee> employees)
        {
            // Simulate successful employee adds.

            return employees;
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>IEmployee.</returns>
        public IEmployee UpdateEmployee(IEmployee employee)
        {
            // Simulate successful update and return the updated employee.
            return employee;
        }

        /// <summary>
        /// Updates the employees.
        /// </summary>
        /// <param name="employees">The employees.</param>
        /// <returns>IEnumerable&lt;IEmployee&gt;.</returns>
        public IEnumerable<IEmployee> UpdateEmployees(IEnumerable<IEmployee> employees)
        {
            // Simulate successful updates and return updated employees.
            return employees;
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>IEmployee.</returns>
        public IEmployee DeleteEmployee(IEmployee employee)
        {
            // Simulate successful delete.
            return employee;
        }

        /// <summary>
        /// Deletes the employees.
        /// </summary>
        /// <param name="employees">The employees.</param>
        /// <returns>IEnumerable&lt;IEmployee&gt;.</returns>
        public IEnumerable<IEmployee> DeleteEmployees(IEnumerable<IEmployee> employees)
        {
            // Simulate successful deletes.
            return employees;
        }


    }
}
