// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="BaseBusinessLogic.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using InheritanceAndInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaces.BusinessLogic
{
    /// <summary>
    /// Class BaseBusinessLogic.
    /// Implements the <see cref="InheritanceAndInterfaces.BusinessLogic.IBaseBusinessLogic{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="InheritanceAndInterfaces.BusinessLogic.IBaseBusinessLogic{T}" />
    public class BaseBusinessLogic<T> : IBaseBusinessLogic<T>
    {
        /// <summary>
        /// The repository
        /// </summary>
        private IRepository<T> _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseBusinessLogic{T}"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public BaseBusinessLogic(IRepository<T> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public IEnumerable<T> GetAll()
        {
            Console.WriteLine("Getting all employees from the repo.");
            return _repository.GetAll();
        }
    }
}
