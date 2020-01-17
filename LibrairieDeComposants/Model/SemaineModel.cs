using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieDeComposants.Model
{
    public class SemaineModel
    {
        private List<JourModel> _jours;
        public List<JourModel> Jours
        {
            get
            {
                if (_jours == null)
                    _jours = new List<JourModel>();

                return _jours;
            }
            set { _jours = value; }
        }
    }
}
