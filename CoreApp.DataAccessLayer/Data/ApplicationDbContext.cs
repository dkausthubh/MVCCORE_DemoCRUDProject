

using coreAppModels;
using Microsoft.EntityFrameworkCore;

namespace CoreApp.DataAccessLayer
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
