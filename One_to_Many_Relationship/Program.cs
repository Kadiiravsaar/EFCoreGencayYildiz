using Microsoft.EntityFrameworkCore;


#region Default Convention

// bire çok ilişkide foreign key tanımlama zorunluluğu yokturrrr

#endregion

class ESirketMany : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-G34LNC7;Database=ESirketManyDb;Trusted_Connection=true;TrustServerCertificate=True;");


    }
    public DbSet<Calisan> Calisanlar { get; set; }
    public DbSet<Departman> Departmanlar { get; set; }

}

class Calisan // dependent entity Çünkü departmana bağlı
{
    public int Id { get; set; }
    public string Ad { get; set; }

    // ******* public int DepartmanId { get; set; } // ******* bire çok ilişkide foreign key tanımlama zorunluluğu yokturrrr **** 
    
    public Departman Departman { get; set; } // navigation  prop
} 


class Departman
{
    public int Id { get; set; }
    public string DepartmanAd { get; set; }

    public ICollection<Calisan> Calisanlar { get; set; } // navigation  prop
}

