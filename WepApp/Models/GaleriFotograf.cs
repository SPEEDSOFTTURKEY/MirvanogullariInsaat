using System;
using System.Collections.Generic;
using WepApp.Models;

namespace WebApp.Models;

public partial class GaleriFotograf
{
    public int Id { get; set; }
    public int KategoriId { get; set; }

    public string? FotografBuyuk { get; set; }

    public string? FotografKucuk { get; set; }

    public int? Durumu { get; set; }

    public DateTime? EklenmeTarihi { get; set; }

    public DateTime? GuncellenmeTarihi { get; set; }
    public virtual Kategori Kategori { get; set; }
}
