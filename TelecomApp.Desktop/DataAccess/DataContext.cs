

using System.Data.Entity;
using TelecomApp.Desktop.Models;

namespace TelecomApp.Desktop.DataAccess
{
    internal class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DbSet<Abonent> Abonents { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Street> Streets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
