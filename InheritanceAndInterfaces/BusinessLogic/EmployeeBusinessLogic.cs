// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="EmployeeBusinessLogic.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using InheritanceAndInterfaces.Models;
using InheritanceAndInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaces.BusinessLogic
{
    /// <summary>
    /// Class EmployeeBusinessLogic.
    /// Implements the <see cref="InheritanceAndInterfaces.BusinessLogic.BaseBusinessLogic{InheritanceAndInterfaces.Models.IEmployee}" />
    /// Implements the <see cref="InheritanceAndInterfaces.BusinessLogic.IEmployeeBusinessLogic" />
    /// </summary>
    /// <seealso cref="InheritanceAndInterfaces.BusinessLogic.BaseBusinessLogic{InheritanceAndInterfaces.Models.IEmployee}" />
    /// <seealso cref="InheritanceAndInterfaces.BusinessLogic.IEmployeeBusinessLogic" />
    public class EmployeeBusinessLogic : BaseBusinessLogic<IEmployee>, IEmployeeBusinessLogic
    {

        /// <summary>
        /// The employee repository
        /// </summary>
        private readonly IEmployeeRepository _employeeRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeBusinessLogic"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public EmployeeBusinessLogic(IEmployeeRepository repository) : base(repository)
        {
            _employeeRepository = repository;
        }

        /// <summary>
        /// Gets the name of the employee by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IEmployee.</returns>
        public IEmployee GetEmployeeByName(string name)
        {
            return _employeeRepository.GetEmployee(name);
        }
    }
}
