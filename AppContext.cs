using Microsoft.EntityFrameworkCore;

namespace TreeViewSample
{
    public class AppContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public AppContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Change here on your connection string
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=root;database=products;"
            );
        }
    }
}
