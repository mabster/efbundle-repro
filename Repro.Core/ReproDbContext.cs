using Microsoft.EntityFrameworkCore;

namespace Repro.Core
{
    public class ReproDbContext : DbContext
    {
        public ReproDbContext(DbContextOptions<ReproDbContext> options)
           : base(options)
        {
        }

        public ReproDbContext()
        {
        }

        public DbSet<Widget> Widgets => Set<Widget>();
    }
}
