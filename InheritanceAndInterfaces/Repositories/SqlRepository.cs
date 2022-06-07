// ***********************************************************************
// Assembly         : InheritanceAndInterfaces
// Author           : DaDuStMaN20
// Created          : 06-06-2022
//
// Last Modified By : DaDuStMaN20
// Last Modified On : 06-07-2022
// ***********************************************************************
// <copyright file="SqlRepository.cs" company="InheritanceAndInterfaces">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaces.Repositories
{
    /// <summary>
    /// Class SqlRepository.
    /// Implements the <see cref="InheritanceAndInterfaces.Repositories.IRepository{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="InheritanceAndInterfaces.Repositories.IRepository{T}" />
    public class SqlRepository<T> : IRepository<T>
    {
        /// <summary>
        /// The database connection
        /// </summary>
        private SqlConnection _dbConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlRepository" /> class.
        /// </summary>
        public SqlRepository()
        {
            // initialize _dbConnection
            _dbConnection = new SqlConnection();
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>IEnumerable&lt;T&gt;.</returns>
        public IEnumerable<T> GetAll()
        {
            Console.WriteLine($"Getting generic items from the sql database. All employees");
             
            // Simulating a successful get.
            var employees = new List<T>();

            return employees;
        }
    }
}
