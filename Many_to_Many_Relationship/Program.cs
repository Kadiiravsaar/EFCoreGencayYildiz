using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


#region Default Convention

//İki entity arasındaki ilişkiyi navigation propertyler üzerinden çoğul olarak kurmalıyız. (ICollection, List)
//Default Convention'da cross table'ı manuel oluşturmak zorunda değiliz. EF Core tasarıma uygun bir şekilde cross table'ı kendisi otomatik basacak ve generate edecektir.
//Ve oluşturulan cross table'ın içerisinde composite primary key'i de otomatik oluşturmuş olacaktır.

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

