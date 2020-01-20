using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Utilisateur
    {

        public Utilisateur()
        {

        }

        [Key]
        public int UtilisateurID { get; set; }
        public String Login { get; set; }
        public String MotDePasse { get; set; }
        public String ProfilImage { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<UtilisateurGroupe> UtilisateurGroupe { get; set; }
    }
}
