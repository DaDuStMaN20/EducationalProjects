// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="SqlEmployeeRepository.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using InheritanceAndInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaces.Repositories
{
    /// <summary>
    /// Class SqlEmployeeRepository.
    /// Implements the <see cref="InheritanceAndInterfaces.Repositories.IEmployeeRepository" />
    /// </summary>
    /// <seealso cref="InheritanceAndInterfaces.Repositories.IEmployeeRepository" />
    public class SqlEmployeeRepository : SqlRepository<IEmployee>, IEmployeeRepository
    {
        /// <summary>
        /// The database connection
        /// </summary>
        private SqlConnection _dbConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlEmployeeRepository" /> class.
        /// </summary>
        public SqlEmployeeRepository()
        {
            // initialize _dbConnection
            _dbConnection = new SqlConnection();
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IEmployee.</returns>
        public IEmployee GetEmployee(string name)
        {
            Console.WriteLine($"Getting employee from the sql database. Name: {name}");
            // dbConnection.Execute("SELECT * FROM Employee WHERE name='name');
            return new Employee(name, "testComp", 8);
        }

        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns>IEnumerable&lt;IEmployee&gt;.</returns>
        public IEnumerable<IEmployee> GetEmployees(string company)
        {
            Console.WriteLine($"Getting employees from the sql database. Company: {company}");

            var employees = new List<IEmployee>();
            employees.Add(new Employee("TestEmp1", company, 10));
            employees.Add(new Employee("TestEmp2", company, 11));
            employees.Add(new Employee("TestEmp3", company, 12));

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
