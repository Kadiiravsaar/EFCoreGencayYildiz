using ChangeTrackerOrj.Contexts;
using ChangeTrackerOrj.Models;

EticaretDbContext context = new EticaretDbContext();

#region Change Tracking nedir
// context üzerinden gelen bütün veriler bir mekanızma sayesinde izlenir

// bu mekanizma Change Tracker mekanizmasıdır

// elimizdeki nesnelerin durumlarını kontrol edip onlara işlemler gerçekleştiren mekanızmadır


#endregion



#region Change Tracking Propertysi
// takip edilen nesnelere erişebilmemizi sağlayan prop ve
// gerektiği takdirde işlemelr gerçekleştirmemizi sağlayan propdur


// DbContext'e gidersen orada public virtual Change Tracking (member'ı) vardır

//var urunler = context.Urunlers.ToList();

//urunler[0].Fiyat = 700; // update
//context.Urunlers.Remove(urunler[8]); // remove
//urunler[2].UrunAdi = "Keke Araba"; // update

//var datas = context.ChangeTracker.Entries(); // şuan hepsi unchanged durumdadır (Yukarıdaki 27 28 29 satırlar olmadan önce)

// savechanges çağırmazsan çalışmayacak yani dbye yansımaz

//Console.WriteLine();

#endregion


#region DetectChanges MEtodu
// EfCore context nesnesi tarafından izlenen tüm nesneleri mekanızma ile takip etmektedir.

// Yapılan değişikliklerin dbye gönderilmeden önce algılandığından emin olmak gerekir

// savechanges metodu çağırldığınnda ef core tarafından otomatik konrol edilir

// savechanges önce detect edecek olduğundan bir maliyet sorunu vardır
#endregion


#region AutoDetectChangesEnabled Property'si
//İlgili metotlar(SaveChanges, Entries) tarafından DetectChanges metodunun otomatik olarak tetiklenmesinin konfigürasyonunu yapmamızı sağlayan proeportydir.
//SaveChanges fonksiyonu tetiklendiğinde DetectChanges metodunu içerisinde default olarak çağırmaktadır. Bu durumda DetectChanges fonksiyonunun kullanımını irademizle yönetmek ve maliyet/performans optimizasyonu yapmak istediğimiz durumlarda AutoDetectChangesEnabled özelliğini kapatabiliriz.
#endregion


#region Entries Metodu
//Context'te ki Entry metodunun koleksiyonel versiyonudur.
//Change Tracker mekanizması tarafından izlenen her entity nesnesinin bigisini EntityEntry türünden elde etmemizi sağlar ve belirli işlemler yapabilmemize olanak tanır.
//Entries metodu, DetectChanges metodunu tetikler. Bu durum da tıpkı SaveChanges'da olduğu gibi bir maliyettir. Buradaki maliyetten kaçınmak için AuthoDetectChangesEnabled özelliğine false değeri verilebilir.

//var urunler = await context.Urunler.ToListAsync();
//urunler.FirstOrDefault(u => u.Id == 7).Fiyat = 123; //Update
//context.Urunler.Remove(urunler.FirstOrDefault(u => u.Id == 8)); //Delete
//urunler.FirstOrDefault(u => u.Id == 9).UrunAdi = "asdasd"; //Update

//context.ChangeTracker.Entries().ToList().ForEach(e =>
//{

//    if (e.State == EntityState.Unchanged)
//    {
//        //:..
//    }
//    else if (e.State == EntityState.Deleted)
//    {
//        //...
//    }
//    //...
//});
#endregion


#region AcceptAllChanges Metodu
//SaveChanges() veya SaveChanges(true) tetiklendiğinde
//EF Core herşeyin yolunda olduğunu varsayarak track ettiği verilerin takibini keser yeni değişikliklerin takip edilmesini bekler. Böyle bir durumda beklenmeyen bir durum/olası bir hata söz konusu olursa eğer EF Core takip ettiği nesneleri brakacağı için bir düzeltme mevzu bahis olamayacaktır.

//Haliyle bu durumda devreye SaveChanges(false) ve AcceptAllChanges metotları girecektir.

//SaveChanges(False), EF Core'a gerekli veritabanı komutlarını yürütmesini söyler ancak gerektiğinde yeniden oynatılabilmesi için değişikleri beklemeye/nesneleri takip etmeye devam eder. Taa ki AcceptAllChanges metodunu irademizle çağırana kadar!

//SaveChanges(false) ile işlemin başarılı olduğundan emin olursanız AcceptAllChanges metodu ile nesnelerden takibi kesebilirsiniz.

//var urunler = await context.Urunler.ToListAsync();
//urunler.FirstOrDefault(u => u.Id == 7).Fiyat = 123; //Update
//context.Urunler.Remove(urunler.FirstOrDefault(u => u.Id == 8)); //Delete
//urunler.FirstOrDefault(u => u.Id == 9).UrunAdi = "asdasd"; //Update

//await context.SaveChangesAsync(false);
//context.ChangeTracker.AcceptAllChanges();

#endregion


#region HasChanges Metodu
//Takip edilen nesneler arasından değişiklik yapılanların olup olmadığının bilgisini verir.
//Arkaplanda DetectChanges metodunu tetikler.
//var result = context.ChangeTracker.HasChanges();
#endregion


#region Entity States
//Entity nesnelerinin durumlarını ifade eder.

#endregion


#region Detached
//Nesnenin change tracker mekanizması tarafıdnan takip edilmediğini ifade eder.
//Urun urun = new();
//Console.WriteLine(context.Entry(urun).State);
//urun.UrunAdi = "asdasd";
//await context.SaveChangesAsync();
#endregion


#region Added
//Veritabanına eklenecek nesneyi ifade eder. Adeed henüz veritabanına işlenmeyen veriyi ifade eder. SaveChanges fonksiyonu çağrıldığında insert sorgusu oluşturucalşığı anlamını gelir.
//Urun urun = new() { Fiyat = 123, UrunAdi = "Ürün 1001" };
//Console.WriteLine(context.Entry(urun).State);
//await context.Urunler.AddAsync(urun);
//Console.WriteLine(context.Entry(urun).State);
//await context.SaveChangesAsync();
//urun.Fiyat = 321;
//Console.WriteLine(context.Entry(urun).State);
//await context.SaveChangesAsync();
#endregion


#region Unchanged
//Veritabanından sorgulandığından beri nesne üzerinde herhangi bir değişiklik yapılmadığını ifade eder. Sorgu neticesinde elde edilen tüm nesneler başlangıçta bu state değerindedir.
//var urunler = await context.Urunler.ToListAsync();

//var data = context.ChangeTracker.Entries();
//Console.WriteLine();
#endregion


#region Modified
//Nesne üzerinde değşiiklik/güncelleme yapıldığını ifade eder. SaveChanges fonksiyonu çağrıldığında update sorgusu oluşturulacağı anlamına gelir.
//var urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 3);
//Console.WriteLine(context.Entry(urun).State);
//urun.UrunAdi = "asdasdasdasdasd";
//Console.WriteLine(context.Entry(urun).State);
//await context.SaveChangesAsync(false);
//Console.WriteLine(context.Entry(urun).State);
#endregion


#region Deleted
//Nesnenin silindiğini ifade eder. SaveChanges fonksiyonu çağrıldığında delete sorgusu oluşturuculağı anlamına gelir.
//var urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 4);
//context.Urunler.Remove(urun);
//Console.WriteLine(context.Entry(urun).State);
//context.SaveChangesAsync();
#endregion


#region Context Nesnesi Üzerinden Change Tracker
//var urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 55);
//urun.Fiyat = 123;
//urun.UrunAdi = "Silgi"; //Modified | Update

#region Entry Metodu55

#region OriginalValues Property'si
//var fiyat = context.Entry(urun).OriginalValues.GetValue<float>(nameof(Urun.Fiyat));
//var urunAdi = context.Entry(urun).OriginalValues.GetValue<string>(nameof(Urun.UrunAdi));
//Console.WriteLine();
#endregion

#region CurrentValues Property'si
//var urunAdi = context.Entry(urun).CurrentValues.GetValue<string>(nameof(Urun.UrunAdi));
#endregion

#region GetDatabaseValues Metodu
//var _urun = await context.Entry(urun).GetDatabaseValuesAsync();
#endregion

#endregion

#endregion


#region Change Tracker'ın Interceptor Olarak Kullanılması

#endregion