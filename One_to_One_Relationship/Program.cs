using Microsoft.EntityFrameworkCore;

#region Default Convention
//class Calisan
//{
//    public int Id { get; set; }
//    public string CalisanAdi { get; set; }

//    public CalisanAdresi CalisanAdresi { get; set; }
//}

//class CalisanAdresi
//{
//    public int Id { get; set; }
//    public int CalisanId { get; set; } // eğer biz bunu yazmazsak ef core hangisainin dependent entitiy olduğunu anlamaz.
//    public string Adres { get; set; }

//    public Calisan Calisan { get; set; }
//}


#endregion

#region Data Annotations

//class Calisan
//{
//    public int Id { get; set; }
//    public string CalisanAdi { get; set; }

//    public CalisanAdresi CalisanAdresi { get; set; }
//}

//class CalisanAdresi
//{
//    public int Id { get; set; } // primary

//    [ForeignKey(nameof(Calisan))] bu da olur

//    public int CalisanId { get; set; }  // foregin 

//    public string Adres { get; set; }

//    public Calisan Calisan { get; set; }
//}


#endregion


#region Fluent Api

class Calisan
{
    public int Id { get; set; }
    public string CalisanAdi { get; set; }

    public CalisanAdresi CalisanAdresi { get; set; }
}

class CalisanAdresi
{
    public int Id { get; set; }
    public string Adres { get; set; }

    public Calisan Calisan { get; set; }
}


#endregion


class ESirketContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-G34LNC7;Database=ESirketDb;Trusted_Connection=true;TrustServerCertificate=True;");
    }
    public DbSet<CalisanAdresi> CalisanAdresis { get; set; }
    public DbSet<Calisan> Calisans { get; set; }


    // modellerin (entitylerin) veritabanında konfigure edilmesini sağlar 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { // fluent api denir

        modelBuilder.Entity<CalisanAdresi>()
            .HasKey(c => c.Id);  // CalisanAdresi içerisindeki ıd primary key özelliği ezilmemesi için 

        modelBuilder.Entity<Calisan>()
             .HasOne(c => c.CalisanAdresi)
            .WithOne(c => c.Calisan)
            .HasForeignKey<CalisanAdresi>(c => c.Calisan);
    }
}


