using Microsoft.EntityFrameworkCore;

namespace Chapter8example3.Models
{
    public class PictureDbContext : DbContext
    {
        public DbSet<Picture> Pictures { get; set; }
        public PictureDbContext(
            DbContextOptions<PictureDbContext> options) : base(options) { 
        }
    }
}
