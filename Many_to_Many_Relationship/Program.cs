using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


#region Default Convention


#endregion

class ESirketMany : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-G34LNC7;Database=ESirketmanytomanyDb;Trusted_Connection=true;TrustServerCertificate=True;");


    }
    public DbSet<Kitap> Kitaplar { get; set; }
    public DbSet<Yazar> Yazarlar { get; set; }

}

class Kitap 
{
    public int Id { get; set; }
    public string KitapAd { get; set; }
    public ICollection<Yazar> Yazarlar { get; set; } // navigation  prop

}


class Yazar
{
    public int Id { get; set; }
    public string YazarAdi { get; set; }
    public ICollection<Kitap> Kitaplar { get; set; } // navigation  prop
}

