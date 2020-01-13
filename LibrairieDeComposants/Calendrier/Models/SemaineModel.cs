using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieDeComposants.Calendrier.Models
{
    public class SemaineModel
    {
        private List<JourModels> _jours;
        public List<JourModels> Jours { get { if (_jours == null) { _jours = new List<JourModels>(); } return _jours; } set{ _jours = value; } }
    }
}
