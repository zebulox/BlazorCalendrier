using LibrairieDeComposants.Calendrier.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace LibrairieDeComposants.Calendrier.Services
{
    public class LocalStorage : IEnregistrerNote
    {

        private ILocalStorageService _localStore { get; set; }

        public LocalStorage()
        {

        }

        public LocalStorage(ILocalStorageService localStore)
        {
            _localStore = localStore;
        }

        public async void EnregistrerNote(JourModels jour)
        {
            if (jour.Notes.Count < 1) return;

            try
            {
                await _localStore.SetItemAsync(jour.Jour.ToString(), jour.Notes[jour.Notes.Count -1]);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }

        //TODO la faire async entièrement
        public List<NoteViewModel> ChargerNotes(DateTime dateDebut, DateTime dateFin)
        {
            try
            {
                List<NoteViewModel> Notes = new List<NoteViewModel>();

                while (dateDebut <= dateFin)
                {
                    String note = _localStore.GetItemAsync<String>(dateDebut.ToString()).Result;

                    if (!String.IsNullOrWhiteSpace(note))
                    {
                        NoteViewModel noteModel = new NoteViewModel() { Date = dateDebut, Note = note };
                        Notes.Add(noteModel);
                    }
                    dateDebut = dateDebut.AddDays(1);
                }
                return Notes; 
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return new List<NoteViewModel>();
            }
        }

        //await localStore.RemoveItemAsync(key);
        //await localStore.ClearAsync();
    }
}
