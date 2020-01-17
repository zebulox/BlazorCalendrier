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
    }
}
