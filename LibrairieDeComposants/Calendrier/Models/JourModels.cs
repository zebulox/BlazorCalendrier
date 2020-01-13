using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieDeComposants.Calendrier.Models
{
    public class JourModels
    {
        private DateTime _jour;
        public DateTime Jour { get {return _jour; }  set {_jour = value; } }

        private String _cssJourClass;
        public String CssJourClass { get { return _cssJourClass; } set { _cssJourClass = value; } }

        private String _cssBadgeClass ;
        public String CssBadgeClass { get { return _cssBadgeClass; } set { _cssBadgeClass = value; } }

        private List<String> _notes;
        public List<String> Notes { get { if (_notes == null) { _notes = new List<string>(); } return _notes; } set {_notes = value; } }

        public void AjouterNote(String note)
        {
            Notes.Add(note);
        }
    }
}
