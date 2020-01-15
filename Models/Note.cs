using System;
using System.ComponentModel.DataAnnotations;

namespace DAL
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
