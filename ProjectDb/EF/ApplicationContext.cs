using DomainProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDb.EF
{
    /// <summary>
    /// The context of database.
    /// </summary>
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }     // The list of users in database.

        /// <summary>
        /// Constructor for application context.
        /// </summary>
        /// <param name="options"></param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
