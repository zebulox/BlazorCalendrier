using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class UtilisateurGroupe
    {
        public UtilisateurGroupe()
        {

        }


        public int UtilisateurID { get; set; }
        [ForeignKey("UtilisateurID")]
        public virtual Utilisateur Utilsateur { get; set; }

        public int GroupeID { get; set; }
        [ForeignKey("GroupeID")]
        public virtual Groupe Groupe { get; set; }

        public bool IsAdmin { get; set; }
    }
}
