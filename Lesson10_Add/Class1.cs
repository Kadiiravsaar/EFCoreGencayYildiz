using Lesson10_Add.Entities;
using Lesson10_Add.Models;

ETicaretContext context = new ETicaretContext();

Urun urun = new Urun()
{
    Name = "sdlsdl",
    Price = 5
};

#region AddAsync Fonksiyon hali
// await context.AddAsync(urun); // bu ise object olarak tip güvensiz ekleme yapar
#endregion


#region DbSet<>.addasync fonk hali
    await context.Uruns.AddAsync(urun);     // ikisi arasındaki fark birisi tip güvenli veri eklemeyi saplar (bu)
    await context.SaveChangesAsync();       // SaveChangesAsync; insert update delete sorgularını oluşturup bir transaction eşliğinde veritabanına gönderip execute eden fonksiyondur.
                                            // eğer oluşturulan sorgulardan herhangi biri başarısız olursa tüm işlemleri geri alır (rollback)

#endregion


#region Birden fazla ürün eklerken nelere dikkat edilmeldir

Urun urun1 = new Urun()
{
    Name = "a ürünü",
    Price = 5
};
Urun urun2 = new Urun()
{
    Name = "b ürünü",
    Price = 5
};
Urun urun3 = new Urun()
{
    Name = "c ürünü",
    Price = 5
};

context.Uruns.AddAsync(urun1); 
context.Uruns.AddAsync(urun2); 
context.Uruns.AddAsync(urun3); 
context.SaveChangesAsync(); // transactionlar birer maliyettir ve tek transaction ile bunu halledebiliriz ( ayrı ayrı yapmak yerine tek bir kez yaptık)

#endregion

#region addrange

context.Uruns.AddRangeAsync(urun1, urun2, urun3);
context.SaveChangesAsync();

#endregion