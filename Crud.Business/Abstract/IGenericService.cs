using System;
using System.Collections.Generic;

namespace Crud.Business.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T GetById(int id);
        List<T> getAll();
    }
}
