using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;
namespace WebAPI.Infrastructure
{
    public class AutoLandDbContext : DbContext
    {
        public AutoLandDbContext(DbContextOptions<AutoLandDbContext> options) : base(options)
        {
        }

        public DbSet<Rent> Rents { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<PriceEstimation> PriceEstimations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO others 

            modelBuilder.Entity<Rent>()
                .Property(r => r.QuoteId)
                .IsRequired();

            modelBuilder.Entity<PriceEstimation>()
                .Property(r => r.QuotaId)
                .IsRequired();

        }
    }
}

