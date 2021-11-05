﻿using System;
using System.Collections.Generic;
using System.Linq;
using Crud.DataAccess.Abstract;
using Crud.Entities;

namespace Crud.DataAccess.Concrete.Ef
{
    public class NoteRepository : INoteDal
    {
        
        public void Add(Notes entity)
        {
            using (Context context = new Context())
            {
                context.Notes.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Notes entity)
        {
            using (Context context = new Context())
            {
                context.Notes.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<Notes> getAll()
        {
            using (Context context = new Context())
            {
                return context.Notes.ToList();
            }
        }

        public Notes GetById(int id)
        {

            using (Context context = new Context())
            {
                return context.Notes.Find(id);
            }
            
        }

        public void Update(Notes entity)
        {
            using (Context context = new Context())
            {
                context.Notes.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
