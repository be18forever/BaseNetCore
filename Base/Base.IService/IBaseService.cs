using common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base.IService
{
    public interface IBaseService
    {

     
            IRepository<T> CreateService<T>() where T : class, new();
        
    }
}
