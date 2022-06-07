// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="lEmployeeRepository.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using InheritanceAndInterfaces.Models;
using System.Collections.Generic;

namespace InheritanceAndInterfaces.Repositories
{
    /// <summary>
    /// Interface IEmployeeRepository
    /// </summary>
    public interface IEmployeeRepository : IRepository<IEmployee>
    {
        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>IEmployee.</returns>
        IEmployee DeleteEmployee(IEmployee employee);

        /// <summary>
        /// Deletes the employees.
        /// </summary>
        /// <param name="employees">The employees.</param>
        /// <returns>IEnumerable&lt;IEmployee&gt;.</returns>
        IEnumerable<IEmployee> DeleteEmployees(IEnumerable<IEmployee> employees);

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IEmployee.</returns>
        IEmployee GetEmployee(string name);

        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns>IEnumerable&lt;IEmployee&gt;.</returns>
        IEnumerable<IEmployee> GetEmployees(string company);

        /// <summary>
        /// Inserts the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>IEmployee.</returns>
        IEmployee InsertEmployee(IEmployee employee);

        /// <summary>
        /// Inserts the employees.
        /// </summary>
        /// <param name="employees">The employees.</param>
        /// <returns>IEnumerable&lt;IEmployee&gt;.</returns>
        IEnumerable<IEmployee> InsertEmployees(IEnumerable<IEmployee> employees);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>IEmployee.</returns>
        IEmployee UpdateEmployee(IEmployee employee);

        /// <summary>
        /// Updates the employees.
        /// </summary>
        /// <param name="employees">The employees.</param>
        /// <returns>IEnumerable&lt;IEmployee&gt;.</returns>
        IEnumerable<IEmployee> UpdateEmployees(IEnumerable<IEmployee> employees);
    }
}