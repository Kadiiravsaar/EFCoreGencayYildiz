using Querying__5.Contexts;
using Querying__5.Models;

EticaretDbContext context = new EticaretDbContext();


//var s = context.Urunlers.Where(x => x.Fiyat > 8 && x.Fiyat < 20).ToList();

#region Single
// Temel amaç oluşan sorguda sadece tek bir sonuç gelsin istiyorsak,
// ******** Birden fazla değer geliyorsa ya da hiç gelmiyorsa Hata Fırlatır ******

//var result = context.Urunlers.Single(x=>x.Fiyat > 8);
//burada hata fırlatacak çünkü fiyatı 8 den büyük olan 2 değer var

#endregion
#region SingeOrDefault
// eğer ki birden fazla değer gelirse hata fırlatır
// /****** Hiç gelmiyorsa NULL döner ***********

//var result = context.Urunlers.SingleOrDefault(x=>x.Fiyat > 5000);
//burada null dönecek çünkü böyle veri yok
//eğer birden fazla gelirse hata döner

#endregion

// Eğer ki sadece tek bir veri olduğundan emin olmak istiyorsak mesela unique email tek olmalı
// // burda single kullanılır

#region First
// yapılan sorguda tek bir veri gelmesi amaçlanırsa kullanılır
// eğer veri gelmeze hata fırlatır

// var result = context.Urunlers.First(x=>x.Fiyat > 8); 
// verilerde opel de merceedes de 10 fiyatına sahip fakat ilkini getirdi
// eğer gelmeseydi hata alacaktım

#endregion


#region FirstOrDefault

// var result = context.Urunlers.First(x=>x.Fiyat > 8); 
// verilerde opel de merceedes de 10 fiyatına sahip fakat ilkini getirdi
// eğer gelmeseydi null alacaktım

#endregion

#region Find

//var result = context.Urunlers.Find(8000);
// içerisine değer olarak default olarak ıd verir ve verilen ıdye göre getirir
// eğer yoksa Null döner

#endregion
Console.WriteLine();





