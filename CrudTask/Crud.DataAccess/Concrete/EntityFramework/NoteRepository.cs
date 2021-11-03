using System;
using System.Collections.Generic;
using System.Linq;
using Crud.DataAccess.Abstract;
using Crud.DataAccess.Concrete.EntityFramework;
using Crud.Entities;

namespace Crud.DataAccess.Concrete
{
    public class NoteRepository : INoteRepository
    {
        GetContext context = new GetContext();

        public void add(Notes note)
        {
            context.Notes.Add(note);
            context.SaveChanges();
        }

        public void delete(Notes note)
        {
            context.Notes.Remove(note);
            context.SaveChanges();
        }

        public List<Notes> GetNotes()
        {
            return context.Notes.ToList();
        }

        public void update(Notes note)
        {
            context.Notes.Update(note);
            context.SaveChanges();
        }
    }
}
