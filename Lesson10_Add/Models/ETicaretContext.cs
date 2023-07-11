using Lesson10_Add.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson10_Add.Models
{
    public class ETicaretContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G34LNC7;Database=ETicaret;Trusted_Connection=true;TrustServerCertificate=True;");
        }

        public DbSet<Urun> Uruns { get; set; }
    }
}

