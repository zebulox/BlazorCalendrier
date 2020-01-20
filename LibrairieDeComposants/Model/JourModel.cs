using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieDeComposants.Model
{
    public class JourModel
    {
        #region private properties

        private DateTime _jour;
        private String _cssJourClass;
        private String _cssBadgeClass;
        private List<NoteViewModel> _notes;

        #endregion

        #region properties

        public DateTime Jour
        {
            get { return _jour; }
            set { _jour = value; }
        }

        public String CssJourClass
        {
            get { return _cssJourClass; }
            set { _cssJourClass = value; }
        }

        public String CssBadgeClass
        {
            get { return _cssBadgeClass; }
            set { _cssBadgeClass = value; }
        }

        public List<NoteViewModel> Notes
        {
            get
            {
                if (_notes == null)
                    _notes = new List<NoteViewModel>();

                return _notes;
            }
            set { _notes = value; }
        }

        #endregion

        #region public functions

        public void AjouterNote(NoteViewModel note)
        {
            Notes.Add(note);
        }

        #endregion
    }
}
