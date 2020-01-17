using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieDeComposants.Model
{
    public class CalendrierModel
    {
        private List<SemaineModel> _semaines;
        public List<SemaineModel> Semaines
        {
            get
            {
                if (_semaines == null)
                    _semaines = new List<SemaineModel>();

                return _semaines;
            }
            set { _semaines = value; }
        }
    }
}
