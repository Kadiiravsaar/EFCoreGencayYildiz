using Microsoft.EntityFrameworkCore;
using The_Data_Update_11;

//ETicaretContext context = new ETicaretContext();

//Urun urun = await context.Urunler.FirstOrDefaultAsync(x => x.Id == 1);
//urun.Name = "EFcoreGencay";

//var urun = await context.Urunler.FirstOrDefaultAsync(x => x.Id == 1);
//urun.Name = "EFcoreGencay";   bunlar da olur fakat farkı bir nesneye aktarmak

//await context.SaveChangesAsync();


#region  ChangeTracker nedir
// ChangeTracker context üzerinden gelen verilerin takibinden sorumlu bir mekanizmadır.
// bu takip mekanızması sayesinde context üzerinden gelen verilerle ilgili işlemler neticesinde günc veya silme sorgularının oluşturacağı anlaşılır.

#endregion

#region Takip edilmeyen nesneler nasıl güncellenir
//ETicaretContext context = new ETicaretContext();

//Urun Urun = new Urun()
//{
//    Id=3,
//    Name="keke"
//};

//context.Urunler.Update(Urun);
//await context.SaveChangesAsync();

#endregion

#region EntityState
// bir entity instancesinin durumunu ifade eder:

//ETicaretContext context = new ETicaretContext();

//Urun urun = new Urun();
//Console.WriteLine(context.Entry(urun).State);

#endregion