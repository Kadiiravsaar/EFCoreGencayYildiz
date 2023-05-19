using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Data_Update_11
{
    public class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ETicaretContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-G34LNC7;Database=ETicaret;Trusted_Connection=true;TrustServerCertificate=True;");

        }
        public DbSet<Urun> Urunler { get; set; }
    }
}
