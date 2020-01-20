using Data.Dal.Interface;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Dal
{
    public class CalendrierContext : DbContext, ICalendrierDataAccessLayer
    {
        public CalendrierContext(DbContextOptions<CalendrierContext> options) : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UtilisateurGroupe>()
                .HasKey(o => new { o.UtilisateurID, o.GroupeID });

            modelBuilder.Entity<UtilisateurGroupe>().HasOne(ug => ug.Groupe).WithMany(g => g.UtilisateurGroupe);
            modelBuilder.Entity<UtilisateurGroupe>().HasOne(ug => ug.Utilsateur).WithMany(u => u.UtilisateurGroupe);

            modelBuilder.Entity<Utilisateur>().HasMany(u => u.Notes).WithOne(n => n.UtilsateurCreateur);
            modelBuilder.Entity<Utilisateur>().HasMany(u => u.UtilisateurGroupe).WithOne(ug => ug.Utilsateur);

            modelBuilder.Entity<Groupe>().HasMany(u => u.UtilisateurGroupe).WithOne(ug => ug.Groupe);
            modelBuilder.Entity<Groupe>().HasMany(u => u.Notes).WithOne(n => n.GroupeNote);

            modelBuilder.Entity<Note>().HasOne(u => u.UtilsateurCreateur).WithMany(u => u.Notes);
            modelBuilder.Entity<Note>().HasOne(u => u.GroupeNote).WithMany(g => g.Notes);

        }
    }
}
