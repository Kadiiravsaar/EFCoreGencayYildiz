using Microsoft.EntityFrameworkCore;

namespace Querying_13_2
{
    public class ETicarettContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G34LNC7;Database=ETicaretDb;Trusted_Connection=true;TrustServerCertificate=True;");

        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Parca> Parcalar { get; set; }
    }
}
