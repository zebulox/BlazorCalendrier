using LibrairieDeComposants.Calendrier.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Components;
using DAL;

namespace LibrairieDeComposants.Calendrier.Services
{
    class WebServiceStorage : IEnregistrerNote
    {
        private HttpClient _httpClient;
        private readonly String _apiPath;
        private List<Note> _notes;

        public List<Note> Notes
        {
            get {
                if (_notes == null) 
                    _notes = new List<Note>();
                
                return _notes; 
            }
            
            set {
                _notes = value; } }


        public WebServiceStorage()
        {

        }

        public WebServiceStorage(HttpClient httpClient, String apiPath)
        {
            _httpClient = httpClient;
            _apiPath = apiPath;
            _notes = new List<Note>();
        }

        public List<NoteViewModel> ChargerNotes(DateTime dateDebut, DateTime dateFin)
        {
            List<NoteViewModel> retour = new List<NoteViewModel>();
            try
            {
                Note[] notes = _httpClient.GetJsonAsync<Note[]>(_apiPath).GetAwaiter().GetResult();//enlever ça et rendre async

                
                foreach (var note in notes)
                {
                    retour.Add(new NoteViewModel() { Date = note.Date, Note = note.Message });
                }

                return new List<NoteViewModel>(retour);
            }
            catch (Exception)
            {
                return new List<NoteViewModel>(retour);
            }

        }

        public void EnregistrerNote(JourModels jour)
        {
            _httpClient.PostJsonAsync<Note>(_apiPath, new Note() { Date = jour.Jour, Message = jour.Notes[jour.Notes.Count -1] });
        }
    }
}
