using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo
{
    public class EFCoreDemoContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source = Books.db");
        }
    }
}