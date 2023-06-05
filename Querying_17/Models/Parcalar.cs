﻿using System;
using System.Collections.Generic;

namespace Querying_17.Models;

public partial class Parcalar
{
    public int Id { get; set; }

    public string ParcaAdi { get; set; } = null!;

    public int? UrunId { get; set; }

    public virtual Urunler? Urun { get; set; }
}