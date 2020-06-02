using common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace common.Core
{
    public class RepositoryFactory : IRepositoryFactory
    {
    
        public IRepository<T> CreateRepository<T>(IXDbContext mydbcontext) where T : class
        {
            return new Repository<T>(mydbcontext);
        }
    }
}
