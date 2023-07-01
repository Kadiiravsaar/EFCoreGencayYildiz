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

class Calisan
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public int DepartmanId { get; set; } // bu Foreign key dir
}
class Departman
{
    public int Id { get; set; } // Principal Key budur
    public string DepartmanAdi { get; set; }

}

#region Principal Key

//Principal entityde ki Id'nin ta kendisidir


#endregion