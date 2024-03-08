using DBGenerator.Model;
using Microsoft.EntityFrameworkCore;

namespace DBGenerator.Context
{
    public class TutorialDbContext : DbContext
    {
        public TutorialDbContext(DbContextOptions<TutorialDbContext> options) : base(options)
        {

        }
        public DbSet<Tutorial> Tutorials { get; set; }
    }
}
