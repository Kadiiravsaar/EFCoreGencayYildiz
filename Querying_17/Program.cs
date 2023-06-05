
using Querying_17.Contexts;
using Querying_17.Models;

EticaretDbContext context = new EticaretDbContext();

#region Genel
// bu fonk ile elde edilen verileri isteğimiz doğrultusunda farklı türlere yansıtabiliriz


#region ToDictionary
// dictionary olarak elte etmemizi sağlar örnek {"Astra",150}
//var resul = context.Urunlers.ToDictionary(x => x.UrunAdi, x => x.Fiyat > 150);
//Console.WriteLine();
#endregion


#region Select
// işlevsel olarak birden fazla davranışı vardr
#region 1.
// 1. sorgunun çekilecek kolonlarını ayarlamamızı sağlar


//var result = context.Urunlers.Select(x=> new Urunler
//{
//    Id = x.Id,
//    Fiyat = x.Fiyat

//}).ToList();  istediğim kolonları çektim diğer kolonlar null kalır
#endregion

#region 2.
// 2. Farklı bi türde ayarlamamızı sağlar

//var result = context.Urunlers.Select(x => new
//{
//    Id = x.Id,
//    Fiyat = x.Fiyat

//}).ToList();  anonim olarak ayarladığım için null olan veriler olmayacak Anonim derken new Urunler yerine sadece new dedik
//Console.WriteLine();

#endregion


#endregion



#region SelectMany  Sonra izle yaz

#endregion


#endregion