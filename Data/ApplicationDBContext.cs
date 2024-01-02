using BookLibrary_Razor.Model;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary_Razor.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<BookCategory> BookCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>().HasData(
                new BookCategory { Id = 1, Name = "Action", DisplayOrder = 1 },
                 new BookCategory { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                  new BookCategory { Id = 3, Name = "History", DisplayOrder = 3 }
                );
        }
    }
}
