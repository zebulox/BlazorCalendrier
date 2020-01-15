using System.Collections.Generic;

namespace LibrairieDeComposants.Calendrier.Models
{
    public class CalendrierModel
    {
        private List<SemaineModel> _semaines;
        public List<SemaineModel> Semaines { 
            get { 
                if (_semaines == null) 
                    _semaines = new List<SemaineModel>();  

                return _semaines; 
            } 
            set {_semaines = value; } }
    }
}
