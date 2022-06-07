// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-06-2022
// ***********************************************************************
// <copyright file="MongoRepository.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaces.Repositories
{
    /// <summary>
    /// Class MongoRepository.
    /// Implements the <see cref="InheritanceAndInterfaces.Repositories.IRepository{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="InheritanceAndInterfaces.Repositories.IRepository{T}" />
    public class MongoRepository<T> : IRepository<T>
    {
        /// <summary>
        /// The database connection
        /// </summary>
        private MongoClient _dbConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="MongoRepository" /> class.
        /// </summary>
        public MongoRepository()
        {
            // initialize _dbConnection
            _dbConnection = new MongoClient();
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public IEnumerable<T> GetAll()
        {
            Console.WriteLine($"Getting generic items from the mongo database. All employees");
            
            // Simulating a successful get.
            var employees = new List<T>();

            return employees;
        }
    }
}
