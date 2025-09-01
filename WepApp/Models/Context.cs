using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WepApp.Models;

namespace WebApp.Models;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }
    public virtual DbSet<AnaSayfaFotograf> AnaSayfaFotograf { get; set; }
    public virtual DbSet<AnaSayfaRakamlari> AnaSayfaRakamlari { get; set; }
    public virtual DbSet<GaleriFotograf> GaleriFotograf { get; set; }
    public virtual DbSet<HakkimizdaBilgileri> HakkimizdaBilgileri { get; set; }
    public virtual DbSet<HakkimizdaFotograf> HakkimizdaFotograf { get; set; }

    public virtual DbSet<IletisimBilgileri> IletisimBilgileri { get; set; }
    public virtual DbSet<IletisimFotograf> IletisimFotograf { get; set; }
    public virtual DbSet<Kategori> Kategori { get; set; }
    public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }

    public virtual DbSet<Video> Video { get; set; }
    public virtual DbSet<Hizmet> Hizmet { get; set; }

    public virtual DbSet <AnaSayfaBannerResim> AnaSayfaBannerResim { get; set; }
    public virtual DbSet<AnaSayfaVideo> AnaSayfaVideo { get; set; }
  

    public virtual DbSet<Logo> Logo { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(
            "Server=GIZEM\\SQLEXPRESS;Database=Mirvanogullari;Trusted_Connection=True;TrustServerCertificate=True;"
        );


    //=> optionsBuilder.UseSqlServer("Server=tcp:95.3.61.234,1433;Initial Catalog=Mirvanogullari;Persist Security Info=False;User ID=speedsoft;Password=5063664643msb*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnaSayfaFotograf>(entity =>
        {
            entity.ToTable("AnaSayfaFotograf");
            entity.Property(e => e.EklenmeTarihi).HasColumnType("datetime");
            entity.Property(e => e.GuncellenmeTarihi).HasColumnType("datetime");
        });

        modelBuilder.Entity<AnaSayfaRakamlari>(entity =>
        {
            entity.ToTable("AnaSayfaRakamlari");
            entity.Property(e => e.EklenmeTarihi).HasColumnType("datetime");
            entity.Property(e => e.GuncellenmeTarihi).HasColumnType("datetime");
        });

        modelBuilder.Entity<GaleriFotograf>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Galeri");
            entity.ToTable("GaleriFotograf");
            entity.Property(e => e.EklenmeTarihi).HasColumnType("datetime");
            entity.Property(e => e.GuncellenmeTarihi).HasColumnType("datetime");
        });

        modelBuilder.Entity<HakkimizdaBilgileri>(entity =>
        {
            entity.ToTable("HakkimizdaBilgileri");
            entity.Property(e => e.EklenmeTarihi).HasColumnType("datetime");
            entity.Property(e => e.GuncellenmeTarihi).HasColumnType("datetime");
        });

        modelBuilder.Entity<HakkimizdaFotograf>(entity =>
        {
            entity.ToTable("HakkimizdaFotograf");
            entity.Property(e => e.EklenmeTarihi).HasColumnType("datetime");
            entity.Property(e => e.GuncellenmeTarihi).HasColumnType("datetime");
        });


        modelBuilder.Entity<IletisimBilgileri>(entity =>
        {
            entity.ToTable("IletisimBilgileri");
            entity.Property(e => e.BankaAdi).HasMaxLength(50);
            entity.Property(e => e.Email1)
                .HasMaxLength(255)
                .HasColumnName("EMail_1");
            entity.Property(e => e.Email2)
                .HasMaxLength(50)
                .HasColumnName("EMail_2");
            entity.Property(e => e.Faks).HasMaxLength(50);
            entity.Property(e => e.IbanNo).HasMaxLength(50);
            entity.Property(e => e.Telefon1)
                .HasMaxLength(50)
                .HasColumnName("Telefon_1");
            entity.Property(e => e.Telefon2)
                .HasMaxLength(50)
                .HasColumnName("Telefon_2");
            entity.Property(e => e.Telefon3)
                .HasMaxLength(50)
                .HasColumnName("Telefon_3");
            entity.Property(e => e.Telefon4)
                .HasMaxLength(50)
                .HasColumnName("Telefon_4");
            entity.Property(e => e.WhatsApp).HasMaxLength(50);
        });

        modelBuilder.Entity<IletisimFotograf>(entity =>
        {
            entity.ToTable("IletisimFotograf");
            entity.Property(e => e.EklenmeTarihi).HasColumnType("datetime");
            entity.Property(e => e.GuncellenmeTarihi).HasColumnType("datetime");
        });

        modelBuilder.Entity<Kullanicilar>(entity =>
        {
            entity.ToTable("Kullanicilar");
            entity.Property(e => e.Adi).HasMaxLength(50);
            entity.Property(e => e.EklenmeTarihi).HasColumnType("datetime");
            entity.Property(e => e.GuncellenmeTarihi).HasColumnType("datetime");
            entity.Property(e => e.Sifre).HasMaxLength(50);
        });



   


        modelBuilder.Entity<Video>(entity =>
        {
            entity.ToTable("Video");

            entity.Property(e => e.EklenmeTarihi).HasColumnType("datetime");
            entity.Property(e => e.GuncellenmeTarihi).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
