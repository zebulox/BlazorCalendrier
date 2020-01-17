using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Note
    {
        public Note()
        {

        }

        [Key]
        public int NoteID { get; set; }

        public DateTime Date { get; set; }

        public String Message { get; set; }
    }
}
