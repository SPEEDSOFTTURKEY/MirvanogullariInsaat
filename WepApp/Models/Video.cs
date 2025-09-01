using System;
using System.Collections.Generic;
using WepApp.Models;

namespace WebApp.Models;

public partial class Video
{
    public int Id { get; set; }

    public string? DosyaYolu { get; set; }

    public int? Durumu { get; set; }

    public DateTime? EklenmeTarihi { get; set; }

    public DateTime? GuncellenmeTarihi { get; set; }
}
