// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="BaseService.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using InheritanceAndInterfaces.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaces.Services
{
    /// <summary>
    /// Class BaseService.
    /// Implements the <see cref="InheritanceAndInterfaces.Services.IBaseService{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="InheritanceAndInterfaces.Services.IBaseService{T}" />
    public class BaseService<T> : IBaseService<T>
    {
        /// <summary>
        /// The business logic
        /// </summary>
        private IBaseBusinessLogic<T> _businessLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseService{T}"/> class.
        /// </summary>
        /// <param name="businessLogic">The business logic.</param>
        public BaseService(IBaseBusinessLogic<T> businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public IEnumerable<T> Get()
        {
            Console.WriteLine($"Received request to get all generic items: {nameof(T)}");
            return _businessLogic.GetAll();
        }

    }
}
