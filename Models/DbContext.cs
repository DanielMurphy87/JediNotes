namespace JediNotes.Models
{
    using Microsoft.EntityFrameworkCore;
    using JediNotes.Models;
    public class NoteContext: DbContext
    {
        public NoteContext(DbContextOptions options) : base(options) { }

        public DbSet<JediNote> JediNote{ get; set;}
    }
}
