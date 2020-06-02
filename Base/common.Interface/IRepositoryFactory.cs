using System;
using System.Collections.Generic;
using System.Text;

namespace common.Interface
{
    public interface IRepositoryFactory
    {
       IRepository<T> CreateRepository<T>(IXDbContext mydbcontext) where T : class;
    }
}
