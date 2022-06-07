// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="IBaseBusinessLogic.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace InheritanceAndInterfaces.BusinessLogic
{
    /// <summary>
    /// Interface IBaseBusinessLogic
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseBusinessLogic<T>
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        IEnumerable<T> GetAll();
    }
}