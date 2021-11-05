using System;
using System.Collections.Generic;
using Crud.Entities;

namespace Crud.WebUI.Models
{
    public class NoteModel
    {
        public int ID { get; set; }
        public string Note { get; set; }
        public DateTime EnrollDate { get; set; }
        public List<Notes> Notes { get; set; }
    }
}
