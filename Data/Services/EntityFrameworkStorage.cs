using Data.Dal;
using Data.Models;
using Data.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class EntityFrameworkStorage : IEnregistrerNote
    {
        private CalendrierContext _context;

        public EntityFrameworkStorage(CalendrierContext context)
        {
            _context = context;
        }
        public async Task<List<Note>> ChargerNotesAsync(DateTime dateDebut, DateTime dateFin)
        {
            try
            {
                if (_context.Database.CanConnect())
                {
                    // all good
                    //return await _context.Notes.Where(n => n.Date >= dateDebut && n.Date <= dateFin).ToListAsync();
                    return  _context.Notes.Where(n => n.Date >= dateDebut && n.Date <= dateFin).ToList();
                }
            }
            catch (Exception e)
            {
                return new List<Note>();

                throw;
            }

            return new List<Note>();
        }

        public async Task EnregistrerNoteAsync(Note note)
        {
             _context.Notes.Add(note);
            _context.SaveChanges();
        }
    }
}
