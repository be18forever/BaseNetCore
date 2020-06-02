using Base.IService;
using common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Service
{
    public class BaseService : IBaseService
    {
        private IRepositoryFactory _repositoryFactory;
        private IXDbContext _mydbcontext;
        public BaseService(IRepositoryFactory repositoryFactory, IXDbContext mydbcontext)
        {
            this._repositoryFactory = repositoryFactory;
            this._mydbcontext = mydbcontext;
        }

        public IRepository<T> CreateService<T>() where T : class, new()
        {
            return _repositoryFactory.CreateRepository<T>(_mydbcontext);
        }
    }
}
