using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;
namespace WebAPI.Infrastructure
{
    public class AutoLandDbContext : DbContext
    {
        private string _connectionString =
            "Data Source=localhost;Initial Catalog=AutoLandDB;Integrated Security=True";
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<PriceEstimation> PriceEstimations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO others 

            modelBuilder.Entity<Rent>()
                .Property(r => r.QuotaId)
                .IsRequired();

            modelBuilder.Entity<PriceEstimation>()
                .Property(r => r.QuotaId)
                .IsRequired();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}

