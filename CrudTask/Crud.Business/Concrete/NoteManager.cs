using System;
using System.Collections.Generic;
using Crud.Business.Abstract;
using Crud.Entities;
using Crud.DataAccess.Abstract;

namespace Crud.Business.Concrete
{
    public class NoteManager : INoteService
    {
        private INoteRepository _noteRepository;

        public NoteManager(INoteRepository noteRepository)
        {
            this._noteRepository = noteRepository;
        }

        public void add(Notes note)
        {
            _noteRepository.add(note);
        }

        public void delete(Notes note)
        {
            _noteRepository.delete(note);

        }

        public List<Notes> getAll()
        {
            return _noteRepository.GetNotes();

        }

        public void update(Notes note)
        {
            _noteRepository.update(note);
        }
    }
}
