// Çalışanlar ve departmanlar adında iki tablo var

// Çalışanlar                          Departmanlar     
//    Id                                      Id
//    Adi                                     DepartmanAdi        
//    DepartmanId

#region Principal entity (Asıl entity)

// kendi başına varolabilen, tek başına ,bağımsız tabloya karşılık gelir
// Departman burda asıl entitydir çünkü departmanlar çalışan olmadan da vardır 

#endregion

#region Dependent entity (Bağımlı entity)

// kendi başına varolamayan bağımlı entitydir 
// Çalışan burda tek başına var olamaz

#endregion

#region Foreign Key

// Principal entity ile Dependent entity arasındaki ilişkiyi sağlar 
// yani DepartmanID burda Foreign keydir

// ***** Dependent Entity de tanımlanır ******
// principal entityde bulunan principal key e karşılık gelir


#endregion

#region Principal Key

//Principal entityde ki Id'nin ta kendisidir


#endregion


class Calisan
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public int DepartmanId { get; set; } // bu Foreign key dir

    public Departman Departman { get; set; } // Navigation prop
}

// bu ikisi arasında hangi ilişki var önce kendin tahmin et bul sonra kontrol et ders 21 dakika 17.20
class Departman
{
    public int Id { get; set; } // Principal Key budur
    public string DepartmanAdi { get; set; }

    public ICollection<Calisan> Calisanlar { get; set; } // Navigation prop

}

#region Navigation Prop nedir

// İlişkisel tablolar arasındaki fiziksel erişimin enty classları üzerinden sağlayan proplardır

// bir prop'un Navigation prop olabilmesi için kesinlikle entity türünden olması gereklidir


#endregion

#region One to One
//Çalışan ile adresi arasındaki ilişki,
//Karı koca arasındaki ilişki.
#endregion

#region One to Many
//Çalışan ile departman arasındaki ilişki,
//Anne ve çocukları arasındaki ilişki.
#endregion

#region Many to Many
//Çalışanlar ile projeler arasındaki ilişki,
//Kardeşler arasındaki ilişki.
#endregion

#region Entity Framework Core'da İlişki Yapılandırma Yöntemleri
#region Default Conventions
//Varsayılan entity kurallarını kullanarak yapılan ilişki yapılandırma yöntemleridir.

//Navigation property'leri kullanarak ilişki şablonlarını çıkarmaktadır.
#endregion

#region Data Annotations Attributes
//Entity'nin niteliklerine göre ince ayarlar yapmamızı sağlayan attribute'lardır. [Key], [ForeignKey]
#endregion

#region Fluent API

//Entity modellerindeki ilişkileri yapılandırırken daha detaylı çalışmamızı sağlayan yöntemdir.

#region HasOne
//İlgili entity'nin ilişkisel entity'ye birebir ya da bire çok olacak şekilde ilişkisini yapılandırmaya başlayan metottur.
#endregion

#region HasMany
//İlgili entity'nin ilişkisel entity'ye çoka bir ya da çoka çok olacak şekilde ilişkisini yapıulandırmaya başlayan metottur.
#endregion

#region WithOne
//HasOne ya da HasMany'den sonra bire bir ya da çoka bir olacak şekilde ilişki yapılandırmasını tamamlayan metottur.
#endregion

#region WithMany
//HasOne ya da HasMany'den sonra bire çok ya da çoka çok olacak şekilde ilişki yapılandırmasını tamamlayan metottur.
#endregion
#endregion
#endregion