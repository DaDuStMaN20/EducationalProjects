// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="IEmployeeBusinessLogic.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using InheritanceAndInterfaces.Models;

namespace InheritanceAndInterfaces.BusinessLogic
{
    /// <summary>
    /// Interface IEmployeeBusinessLogic
    /// Implements the <see cref="InheritanceAndInterfaces.BusinessLogic.IBaseBusinessLogic{InheritanceAndInterfaces.Models.IEmployee}" />
    /// </summary>
    /// <seealso cref="InheritanceAndInterfaces.BusinessLogic.IBaseBusinessLogic{InheritanceAndInterfaces.Models.IEmployee}" />
    public interface IEmployeeBusinessLogic : IBaseBusinessLogic<IEmployee>
    {
        /// <summary>
        /// Gets the name of the employee by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IEmployee.</returns>
        IEmployee GetEmployeeByName(string name);
    }
}