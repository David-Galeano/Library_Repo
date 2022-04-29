using LIBRARY_DG.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace LIBRARY_DG.Data.Service
{
    public class LibraryRepository : DbContext
    {
        public LibraryRepository(DbContextOptions<LibraryRepository> options): base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}