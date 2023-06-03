using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Querying_13_2
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }
        public ICollection<Parca> Parca { get; set; }
    }
}
