using System;
using System.ComponentModel.DataAnnotations;

namespace Crud.Entities
{
    public class Notes
    {
        public int ID { get; set; }
        public string Note { get; set; }
        public DateTime EnrollDate { get; set; }
    }
}
