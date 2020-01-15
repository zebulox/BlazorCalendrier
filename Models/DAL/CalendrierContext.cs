using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CalendrierContext : DbContext
    {
        public CalendrierContext(DbContextOptions<CalendrierContext> options) : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }
    }
}
