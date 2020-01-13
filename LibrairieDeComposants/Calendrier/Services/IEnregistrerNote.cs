using LibrairieDeComposants.Calendrier.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieDeComposants.Calendrier.Services
{
    public interface IEnregistrerNote
    {
        void EnregistrerNote(JourModels jour);

        List<NotePersistanceModel> ChargerNotes(DateTime dateDebut, DateTime dateFin);
    }
}
