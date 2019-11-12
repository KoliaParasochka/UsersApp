using DomainProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Interfaces
{
    /// <summary>
    /// Includes the properties of interfaces
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
    }
}
