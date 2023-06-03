using Microsoft.EntityFrameworkCore;
using Querying_13_2;
using System.Runtime.Serialization.Formatters;
#region Ürün Ekleme Algoritması
//int sayac = 3;
//int _Fiyat = 10;

//for (int i = 0; i < 1000; i++)
//{
//    Urun urun = new Urun()
//    {

//        UrunAdi = $"Ürün {sayac} ",
//        Fiyat = _Fiyat + 2
//    };
//    context.Urunler.Add(urun);
//    sayac++;
//    _Fiyat += 2;
//}
//context.SaveChanges();
//Console.WriteLine();
#endregion



ETicarettContext context = new ETicarettContext();

#region 13.ders biter

//var urunler = context.Urunler.ToList();
//var urunler1 = (from urun in context.Urunler
//                select urun).ToList();

//foreach (var urunss in urunler)
//{
//    Console.WriteLine(urunss.UrunAdi + "" + urunss.Fiyat);
//}

#endregion

#region 14. Ders Çoğul veri getiren sorgular


//var urunler = context.Urunler.Where(u => u.Id>500).ToList();


var urunler = from urun in context.Urunler
           where urun.Id > 50 && urun.UrunAdi.EndsWith("6")
           select urun;
var data = await urunler.ToListAsync();
Console.WriteLine();
#endregion
