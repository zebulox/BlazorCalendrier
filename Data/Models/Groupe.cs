using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Groupe
    {
        public Groupe()
        {

        }

        [Key]
        public int GroupeID { get; set; }

        public String Nom { get; set; }

        public virtual ICollection<Note> Notes { get; set; }

        public virtual ICollection<UtilisateurGroupe> UtilisateurGroupe { get; set; }


    }
}
