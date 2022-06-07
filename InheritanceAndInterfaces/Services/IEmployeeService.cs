// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="IEmployeeService.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using InheritanceAndInterfaces.Models;

namespace InheritanceAndInterfaces.Services
{
    /// <summary>
    /// Interface IEmployeeService
    /// Implements the <see cref="InheritanceAndInterfaces.Services.IBaseService{InheritanceAndInterfaces.Models.IEmployee}" />
    /// </summary>
    /// <seealso cref="InheritanceAndInterfaces.Services.IBaseService{InheritanceAndInterfaces.Models.IEmployee}" />
    public interface IEmployeeService : IBaseService<IEmployee>
    {
        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IEmployee.</returns>
        IEmployee GetEmployee(string name);
    }
}