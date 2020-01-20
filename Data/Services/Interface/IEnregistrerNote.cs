using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.Interface
{
    public interface IEnregistrerNote
    {
        Task EnregistrerNoteAsync(Note note);
        Task EffacerNoteAsync(Note note);
        Task<List<Note>> ChargerNotesAsync(DateTime dateDebut, DateTime dateFin);
    }
}
