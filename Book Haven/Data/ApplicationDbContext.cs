using Microsoft.EntityFrameworkCore;

namespace Book_Haven.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

    }
}
