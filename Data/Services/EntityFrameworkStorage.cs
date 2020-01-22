using Data.Dal;
using Data.Models;
using Data.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class EntityFrameworkStorage : IEnregistrerNote, IAuthentifier
    {

        #region private properties

        private CalendrierContext _context;

        #endregion

        #region constructor

        public EntityFrameworkStorage(CalendrierContext context)
        {
            _context = context;
        }

        #endregion

        #region public functions

        public async Task<List<Note>> ChargerNotesAsync(DateTime dateDebut, DateTime dateFin)
        {
            try
            {
                if (_context.Database.CanConnect())
                {
                    // all good
                    return  _context.Notes.Where(n => n.Date >= dateDebut && n.Date <= dateFin).Include(u => u.UtilsateurCreateur).ToList();
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
            try
            {
                _context.Notes.Add(note);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task EffacerNoteAsync(Note note)
        {
            try
            {
                Note noteToDelete = _context.Notes.Where(n => n.NoteID == note.NoteID).FirstOrDefault();
                if (noteToDelete != null)
                {
                    _context.Notes.Remove(noteToDelete);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public bool LogIn(string login, string password)
        {
            String hash;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                hash = GetHash(sha256Hash, password);
            }

            return _context.Utilisateur.Any(u => u.Login == login && u.MotDePasse == hash);

        }

        public void CréerUtilisateur(Utilisateur utilisateur)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {

                utilisateur.MotDePasse = GetHash(sha256Hash, utilisateur.MotDePasse);
            }
            _context.Utilisateur.Add(utilisateur);
            _context.SaveChanges();
        }

        public bool CheckLoginAvailability(Utilisateur utilisateur)
        {
            return !_context.Utilisateur.Any(u => u.Login == utilisateur.Login);
        }

        public Utilisateur GetUtilisateur(string login, string password)
        {
            String hash;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                hash = GetHash(sha256Hash, password);
            }
            return _context.Utilisateur.Include(u => u.UtilisateurGroupe)
                                       .ThenInclude(UtilisateurGroupe => UtilisateurGroupe.Groupe)
                                       .FirstOrDefault(u => u.Login == login && u.MotDePasse == hash);
        }

        public void SaveUserPicture(Utilisateur user)
        {
            Utilisateur utilisateur = _context.Utilisateur.Where(u => u.Login == user.Login && u.MotDePasse == user.MotDePasse).FirstOrDefault();
            if (utilisateur == null)
            {
                return;
            }
            utilisateur.ProfilImage = user.ProfilImage;
            _context.SaveChanges();
        }

        #endregion

        #region private functions

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        #endregion

    }
}
