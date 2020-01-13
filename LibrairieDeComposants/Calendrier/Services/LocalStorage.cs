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
            try
            {
                await _localStore.SetItemAsync(jour.Jour.ToString(), jour.Notes[0]);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                throw;
            }
        }

        //TODO la faire async entièrement
        List<NotePersistanceModel> IEnregistrerNote.ChargerNotes(DateTime dateDebut, DateTime dateFin)
        {
            try
            {
                List<NotePersistanceModel> Notes = new List<NotePersistanceModel>();

                while (dateDebut <= dateFin)
                {
                    String note = _localStore.GetItemAsync<String>(dateDebut.ToString()).Result;

                    if (!String.IsNullOrWhiteSpace(note))
                    {
                        NotePersistanceModel noteModel = new NotePersistanceModel() { Date = dateDebut, Note = note };
                        Notes.Add(noteModel);
                    }
                    dateDebut = dateDebut.AddDays(1);
                }
                return Notes; 
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                throw;
            }
        }

        //await localStore.RemoveItemAsync(key);
        //await localStore.ClearAsync();
    }
}
