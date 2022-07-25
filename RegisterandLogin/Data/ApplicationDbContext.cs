using RegisterandLogin.Models;
using Microsoft.EntityFrameworkCore;

namespace RegisterandLogin.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }
        public DbSet<User> Users { get; set; }

    }
}
