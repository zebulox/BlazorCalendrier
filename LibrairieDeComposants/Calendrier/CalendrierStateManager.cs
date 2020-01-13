using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using LibrairieDeComposants.Calendrier.Models;
using LibrairieDeComposants.Calendrier.Services;
using Blazored.LocalStorage;

namespace LibrairieDeComposants.Calendrier
{
    public class CalendrierStateManager
    {
        public String DateFormat { get; private set; }
        public CultureInfo Culture { get; private set; }

        private DateTime _dateReference = DateTime.Now;
        public DateTime DateReference { get { return _dateReference; } private set { _dateReference = value; } }


        private CalendrierModel _calendrier;
        public CalendrierModel Calendrier
        {
            get
            {
                if (_calendrier == null)
                {
                    _calendrier = new CalendrierModel();
                } 
                return _calendrier; 
            } 
            set { _calendrier = value; } }

        private int _moisSelectione;
        public int MoisSelectione
        {
            get => _moisSelectione;
            set
            {
                if (value <= 0)
                {
                    _moisSelectione = 12;
                    DateReference = new DateTime(DateReference.Year - 1, _moisSelectione, 1);
                }
                else if (value > 12)
                {
                    _moisSelectione = 1;
                    DateReference = new DateTime(DateReference.Year + 1, _moisSelectione, 1);
                }
                else
                {
                    _moisSelectione = value;
                    DateReference = new DateTime(DateReference.Year, _moisSelectione, 1);
                }

                initialiseCalendrier(DateReference);
            }
        }

        public void UseCulture (String culture)
        {
            if (!CultureExists(culture)) Culture = new CultureInfo("fr-FR");
            else
            {
                Culture = new CultureInfo(culture);
            }
        }

        public void UseDateFormat(String dateFormat)
        {
            try
            {
                String formattedDate = DateTime.Now.ToString(dateFormat);
                DateTime.Parse(formattedDate);
                DateFormat = dateFormat;
            }
            catch (Exception)
            {
                DateFormat = "";
            }
        }


        private static bool CultureExists(string name)
        {
            return new List<CultureInfo>(CultureInfo.GetCultures(CultureTypes.AllCultures)).Any(e => e.Name.Equals(name));
        }

        private void initialiseCalendrier(DateTime jourDebut)
        {
            _calendrier = new CalendrierModel();
            int year = jourDebut.Year, month = jourDebut.Month;
            DateTime firstDay = jourDebut.AddDays(-jourDebut.Day + 1) // on se recalle sur le premier jour du mois
                                         .AddDays(-(int)jourDebut.AddDays(-jourDebut.Day + 1).DayOfWeek); // on soustrait du premier jour du mois le numéro du jour de la semaine

            while ((year > firstDay.Year && month <= firstDay.Month) || (year == firstDay.Year && month >= firstDay.Month))
            {
                SemaineModel tmpSem = new SemaineModel();
                for (int i = 0; i < 7; i++)
                {
                    JourModels jour = new JourModels();
                    jour.Jour = firstDay;
                    jour.CssJourClass = "jour";
                    jour.CssBadgeClass = "badge-dark";
                    tmpSem.Jours.Add(jour);

                    firstDay = firstDay.AddDays(1);
                }
                _calendrier.Semaines.Add(tmpSem);
            }
        }


        private JourModels _jourSelectionne;
        public JourModels JourSelectionne 
        { 
            get 
            { 
                if (_jourSelectionne == null) 
                {
                    _jourSelectionne = new JourModels() { CssBadgeClass = "badge-dark", CssJourClass = "jour", Jour = DateTime.Now }; 
                }
                return _jourSelectionne; 
            } 
            set {_jourSelectionne = value; } }
        

    }
}
