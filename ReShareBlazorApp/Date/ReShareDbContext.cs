using Microsoft.EntityFrameworkCore;

namespace ReShareBlazorApp.Date
{
    public class ReShareDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ReShareDbContext(DbContextOptions<ReShareDbContext> options) : base(options)
        {

        }

    }
}
