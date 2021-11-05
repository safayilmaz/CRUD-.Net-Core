using System;
using System.Collections.Generic;
using Crud.DataAccess.Concrete.Ef;
using Crud.Entities;

namespace Crud.DataAccess.Abstract
{
    public interface IGenericDal<T> 
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T GetById(int id);
        void DeleteAll();
        List<T> getAll();
    }
}
