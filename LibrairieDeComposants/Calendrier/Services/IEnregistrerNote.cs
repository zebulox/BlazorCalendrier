using LibrairieDeComposants.Calendrier.Models;
using System;
using System.Collections.Generic;

namespace LibrairieDeComposants.Calendrier.Services
{
    public interface IEnregistrerNote //=> voir https://www.blogofpi.com/crud-using-blazor-and-entity-framework-core/
    {
        void EnregistrerNote(JourModels jour);

        List<NoteViewModel> ChargerNotes(DateTime dateDebut, DateTime dateFin);
    }
}
