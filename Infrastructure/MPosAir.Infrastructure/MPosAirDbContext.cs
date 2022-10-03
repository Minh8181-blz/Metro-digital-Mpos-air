using Microsoft.EntityFrameworkCore;
using MPosAir.Domain.Entities;

namespace MPosAir.Infrastructure
{
    public class MPosAirDbContext : DbContext
    {
        public MPosAirDbContext(DbContextOptions<MPosAirDbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Basket> Baskets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var basketTableBuider = modelBuilder.Entity<Basket>().ToTable("Baskets");
            basketTableBuider
                .Property(p => p.TotalNet)
                .HasColumnType("decimal(12,2)");

            basketTableBuider
                .Property(p => p.TotalGross)
                .HasColumnType("decimal(12,2)");

            var articleTableBuilder = modelBuilder.Entity<Article>().ToTable("Articles");
            articleTableBuilder
                .Property(p => p.Price)
                .HasColumnType("decimal(12,2)");
        }
    }
}
