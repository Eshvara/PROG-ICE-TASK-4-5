using Book_Haven.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Haven.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Non-fiction", DisplayOrder = 1 },
                new Category { CategoryId = 2, Name = "Romance", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "Fiction", DisplayOrder = 3 },
                new Category { CategoryId = 4, Name = "Mystery", DisplayOrder = 4 },
                new Category { CategoryId = 5, Name = "Fantasy", DisplayOrder = 5 }
                );
        }

    }
}
