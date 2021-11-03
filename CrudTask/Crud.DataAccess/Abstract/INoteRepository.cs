using System;
using System.Collections.Generic;
using Crud.Entities;

namespace Crud.DataAccess.Abstract
{
    public interface INoteRepository
    {
        void add(Notes note);
        void update(Notes note);
        void delete(Notes note);
        List<Notes> GetNotes();

    }
}
