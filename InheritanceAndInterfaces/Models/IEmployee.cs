// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="IEmployee.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace InheritanceAndInterfaces.Models
{
    /// <summary>
    /// Interface IEmployee
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Gets or sets the age of the employee.
        /// </summary>
        /// <value>The age of the employee.</value>
        int Age { get; set; }

        /// <summary>
        /// Gets or sets the company that the employee works at.
        /// </summary>
        /// <value>The company.</value>
        string Company { get; set; }

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>The name of the employee.</value>
        string Name { get; set; }

        /// <summary>
        /// Introduces the yourself.
        /// </summary>
        void IntroduceYourself();
    }
}