using KATSEFET.Modells;
using KATSEFET.Models;
using Microsoft.EntityFrameworkCore;

namespace KATSEFET.Data
{
    public class KATSEFETContext:DbContext

    {
        public KATSEFETContext(DbContextOptions<KATSEFETContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Admin> Admins => Set<Admin>();
        public DbSet<Order> Orders => Set<Order>();


    }
}
