using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public DateTime DateCreationNote { get; set; }
        public String Message { get; set; }
        public int Createur { get; set; }
        [ForeignKey("Createur")]
        public virtual Utilisateur UtilsateurCreateur { get; set; }

        public int Groupe { get; set; }
        [ForeignKey("Groupe")]
        public virtual Groupe GroupeNote { get; set; }
    }
}
