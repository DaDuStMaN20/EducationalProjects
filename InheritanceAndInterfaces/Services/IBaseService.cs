// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="IBaseService.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace InheritanceAndInterfaces.Services
{
    /// <summary>
    /// Interface IBaseService
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseService<T>
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        IEnumerable<T> Get();
    }
}