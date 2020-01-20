using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieDeComposants.Model
{
    public class NoteViewModel
    {
        public int NoteId { get; set; }
        public String Note { get; set; }
        public DateTime Date { get; set; }
        public String CreateurNom { get; set; }
        public String CreateurAvatar { get; set; }
        public DateTime DateCreationNote { get; set; }

        public int GroupeID { get; set; }
    }
}
