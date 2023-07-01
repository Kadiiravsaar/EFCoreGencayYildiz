﻿using System;
using System.Collections.Generic;

namespace ChangeTrackerOrj.Models;

public partial class Urunler
{
    public int Id { get; set; }

    public string UrunAdi { get; set; } = null!;

    public int Fiyat { get; set; }

    public virtual ICollection<Parcalar> Parcalars { get; set; } = new List<Parcalar>();
}