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

#region İlişki Türleri
#region One to One

#endregion

#region One to Many

#endregion

#region Many to Many

#endregion
#endregion