using System;
using System.Collections.Generic;
using Crud.Business.Abstract;
using Crud.DataAccess.Abstract;
using Crud.Entities;

namespace Crud.Business.Concrete
{
    public class NoteManager:INoteService
    {

        private INoteDal _noteDal;

        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }

        public void Add(Notes t)
        {
            _noteDal.Add(t);
        }

        public void Delete(Notes t)
        {
            _noteDal.Delete(t);
        }

        public List<Notes> getAll()
        {
            return _noteDal.getAll();
        }

        public Notes GetById(int id)
        {
            return _noteDal.GetById(id);
        }

        public void Update(Notes t)
        {
            _noteDal.Update(t);
        }
    }
}
