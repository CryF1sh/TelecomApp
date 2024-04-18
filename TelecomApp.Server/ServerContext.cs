using Microsoft.EntityFrameworkCore;
using TelecomApp.Server.Entities;

namespace TelecomApp.Server
{
    public class ServerContext : DbContext
    {
        public DbSet<Abonent> Abonents { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Street> Streets { get; set; }

        public ServerContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public ServerContext(DbContextOptions<ServerContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: connect many-to many and one-to-many
            base.OnModelCreating(modelBuilder);
        }
    }
}
