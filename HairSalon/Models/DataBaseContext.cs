using Microsoft.EntityFrameworkCore;

namespace DataBase.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public virtual DbSet<Stylist> Stylists { get; set; }

        public DataBaseContext(DbContextOptions options) : base(options) { }
    }
}