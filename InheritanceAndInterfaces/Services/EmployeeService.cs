// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-07-2022
// ***********************************************************************
// <copyright file="EmployeeService.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using InheritanceAndInterfaces.BusinessLogic;
using InheritanceAndInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaces.Services
{
    /// <summary>
    /// Class EmployeeService.
    /// Implements the <see cref="InheritanceAndInterfaces.Services.BaseService{InheritanceAndInterfaces.Models.IEmployee}" />
    /// Implements the <see cref="InheritanceAndInterfaces.Services.IEmployeeService" />
    /// </summary>
    /// <seealso cref="InheritanceAndInterfaces.Services.BaseService{InheritanceAndInterfaces.Models.IEmployee}" />
    /// <seealso cref="InheritanceAndInterfaces.Services.IEmployeeService" />
    public class EmployeeService : BaseService<IEmployee>, IEmployeeService
    {
        /// <summary>
        /// The employee business logic
        /// </summary>
        private IEmployeeBusinessLogic _employeeBusinessLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeService"/> class.
        /// </summary>
        /// <param name="businessLogic">The business logic.</param>
        public EmployeeService(IEmployeeBusinessLogic businessLogic) : base(businessLogic)
        {
            _employeeBusinessLogic = businessLogic;
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>IEmployee.</returns>
        public IEmployee GetEmployee(string name)
        {
            name = name.Trim();

            return _employeeBusinessLogic.GetEmployeeByName(name);
        }
    }
}
