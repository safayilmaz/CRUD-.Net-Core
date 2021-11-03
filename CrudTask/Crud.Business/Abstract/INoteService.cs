using System;
using System.Collections.Generic;
using Crud.Entities;
namespace Crud.Business.Abstract
{
    public interface INoteService
    {
        void add(Notes note);
        void delete(Notes note);
        void update(Notes note);
        List<Notes> getAll();
    }
}
