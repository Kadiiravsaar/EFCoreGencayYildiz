
using Microsoft.EntityFrameworkCore;

public class ETicaret : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-G34LNC7;Database=ETicaret;Trusted_Connection=true;TrustServerCertificate=True;");

    }
        public DbSet<Urun> Uruns { get; set; }
}



public class Urun
{
    public int Id { get; set; } // ıd olmayan bir entity hata fırlatır
    public string UrunAdi { get; set; }
    public decimal UrunFiyati { get; set; }

}
