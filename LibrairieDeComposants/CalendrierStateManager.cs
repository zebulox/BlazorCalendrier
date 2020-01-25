using Data.Dal;
using Data.Dal.Interface;
using Data.Models;
using Data.Services;
using Data.Services.Interface;
using LibrairieDeComposants.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LibrairieDeComposants
{
    public class CalendrierStateManager
    {
        #region private properties

        private ICalendrierDataAccessLayer _calendrierContext;
        private IEnregistrerNote _dataservice;
        private CalendrierModel _calendrier;
        private int _moisSelectione;
        private DateTime _dateReference = DateTime.Now;
        private JourModel _jourSelectionne;
        private Utilisateur _currentUser;
        private NoteViewModel _noteVm;


        #endregion

        #region constructor



        #endregion

        #region properties

        public String DateFormat { get; private set; }
        public String ShortdateFormat { get; private set; }
        public CultureInfo Culture { get; private set; }
        public DateTime DateReference { get { return _dateReference; } private set { _dateReference = value; } }
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
        public JourModel JourSelectionne
        {
            get
            {
                if (_jourSelectionne == null)
                {
                    _jourSelectionne = new JourModel() { CssBadgeClass = "badge-dark", CssJourClass = "jour", Jour = DateTime.Now };
                }
                return _jourSelectionne;
            }
            set { _jourSelectionne = value; }
        }
        public Utilisateur CurrentUser { get { return _currentUser; } set { _currentUser = value; } }
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
            set { _calendrier = value; }
        }

        public NoteViewModel NoteVm 
        { 
            get 
            { 
                if(_noteVm == null)
                {
                    _noteVm = new NoteViewModel();
                }
                return _noteVm;
            } 
            set { _noteVm = value; }
        }

        #endregion

        #region public functions

        public void InitDataAccess(ICalendrierDataAccessLayer calendrierContext)
        {
            _calendrierContext = calendrierContext;

            if (calendrierContext is CalendrierContext)
            {
                _dataservice = new EntityFrameworkStorage(calendrierContext as CalendrierContext);
            }
            //else if (calendrierContext is ILocalStorageService)
            //{
            //    //_dataservice = new LocalStorage(calendrierContext as ILocalStorageService);
            //}

        }

        public void UseCulture(String culture)
        {
            if (!CultureExists(culture)) Culture = new CultureInfo("fr-FR");
            else
            {
                Culture = new CultureInfo(culture);
            }
        }

        public void UseDateFormat(String dateFormat)
        {
            DateFormat = "";
            if (IsValiddateFormat(dateFormat))
            {
                DateFormat = dateFormat;
            }
        }

        public void UseShortDateFormat(String shortdateFormat)
        {
            ShortdateFormat = "";
            if (IsValiddateFormat(shortdateFormat))
            {
                ShortdateFormat = shortdateFormat;
            }
        }

        public void EnregistrerNote(NoteViewModel noteViewModel)
        {
            _dataservice.EnregistrerNoteAsync(new Note() { Date = noteViewModel.Date, 
                                                           Message = noteViewModel.Note, 
                                                           UtilsateurCreateur = CurrentUser, 
                                                           DateCreationNote = noteViewModel.DateCreationNote,
                                                           Groupe = noteViewModel.GroupeID});
        }

        public void EffacerNote(NoteViewModel noteVm)
        {
            JourModel jour = TrouverJourDansCalendrier(noteVm.Date);
            jour.Notes.Remove(noteVm);


            _dataservice.EffacerNoteAsync(new Note() { NoteID = noteVm.NoteId});

        }

        public void DefinirGroupeParDefault()
        {
            NoteVm.GroupeID = CurrentUser.UtilisateurGroupe.ElementAt(0).GroupeID;
        }

        public void CreerGroupe(String nomGroupe)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region private functions
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
                    JourModel jour = new JourModel();
                    jour.Jour = firstDay;
                    jour.CssJourClass = "jour";
                    jour.CssBadgeClass = "badge-dark";
                    tmpSem.Jours.Add(jour);

                    firstDay = firstDay.AddDays(1);
                }
                _calendrier.Semaines.Add(tmpSem);
            }
            //une fois le calendrier modélisé on charge les messages
            ChargerNotes();
        }

        private void ChargerNotes()
        {
            DateTime dateDebut = Calendrier.Semaines.ElementAt(0).Jours.ElementAt(0).Jour;
            int nbjours = 0;
            foreach (SemaineModel semaine in Calendrier.Semaines)
            {
                nbjours += semaine.Jours.Count();
            }

            DateTime dateFin = dateDebut.AddDays(nbjours);
            List<Note> notes = _dataservice.ChargerNotesAsync(dateDebut, dateFin).Result;

            
            foreach (Note note in notes)
            {
                JourModel jour = TrouverJourDansCalendrier(note.Date);
                jour.Notes.Add(new NoteViewModel()
                {
                    Note = note.Message,
                    Date = jour.Jour,
                    CreateurNom = note.UtilsateurCreateur.Login,
                    CreateurAvatar = note.UtilsateurCreateur.ProfilImage,
                    DateCreationNote = note.DateCreationNote,
                    NoteId = note.NoteID,
                    GroupeID = note.Groupe
                });
            }
        }

        private JourModel TrouverJourDansCalendrier(DateTime date)
        {
            JourModel jour = null;

            foreach (SemaineModel semaine in Calendrier.Semaines)
            {
                foreach (JourModel j in semaine.Jours)
                {
                    if (date.Year == j.Jour.Year && date.Month == j.Jour.Month && date.Day == j.Jour.Day)
                        jour = j;//et oui... le jour J
                }
            }

            return jour;
        }

        private bool IsValiddateFormat(String dateFormat)
        {
            try
            {
                String formattedDate = DateTime.Now.ToString(dateFormat);
                DateTime.Parse(formattedDate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

    }
}
