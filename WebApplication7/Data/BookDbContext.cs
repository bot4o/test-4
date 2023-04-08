using Microsoft.EntityFrameworkCore;

namespace WebApplication7.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Book> Book { get; set; }

        public DbSet<Models.Login> Login { get; set; }
    }
}
