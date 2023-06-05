//  Scaffold-DbContext 'Server=DESKTOP-G34LNC7;Database=ETicaretDb;Trusted_Connection=true;TrustServerCertificate=True;' Microsoft.EntityFrameworkCore.SqlServer -ContextDir Contexts -OutputDir Models

using Querying_18_Gruopby.Contexts;

EticaretDbContext context = new EticaretDbContext();

//var datass = (from urun in context.Urunlers
//              orderby urun.Fiyat descending
//              select urun).ToList();

var result = context.Urunlers.GroupBy(u => u.Fiyat).Select(grp => new
{
    Count = grp.Count(),
    Fiyat = grp.Key
}).ToList(); // urunlerin fiyatına göre grupladım

var datas = (from urun in context.Urunlers
             orderby urun.Fiyat descending
             group urun by urun.Fiyat
            into grpp
             select new
             {
                 Fiyat = grpp.Key,
                 Count = grpp.Count()
             }).ToList();



Console.WriteLine();
