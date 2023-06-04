using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Querying__5.Models;

namespace Querying__5.Contexts;

public partial class EticaretDbContext : DbContext
{
    public EticaretDbContext()
    {
    }

    public EticaretDbContext(DbContextOptions<EticaretDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Parcalar> Parcalars { get; set; }

    public virtual DbSet<Urunler> Urunlers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-G34LNC7;Database=ETicaretDb;Trusted_Connection=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Parcalar>(entity =>
        {
            entity.ToTable("Parcalar");

            entity.HasIndex(e => e.UrunId, "IX_Parcalar_UrunId");

            entity.HasOne(d => d.Urun).WithMany(p => p.Parcalars).HasForeignKey(d => d.UrunId);
        });

        modelBuilder.Entity<Urunler>(entity =>
        {
            entity.ToTable("Urunler");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
