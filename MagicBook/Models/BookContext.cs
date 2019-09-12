using System.Data.Entity;

namespace MagicBook.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("MagicBook")
        {}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}