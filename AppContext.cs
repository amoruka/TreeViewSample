using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// Get categories of first level
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategoriesWithoutParent()
        {
            return Categories.Where(x => x.Parent == null).ToList();
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
