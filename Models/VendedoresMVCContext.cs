using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VendedoresMVC.Models;

public partial class VendedoresMVCContext : DbContext
{
    public VendedoresMVCContext()
    {
    }

    public VendedoresMVCContext(DbContextOptions<VendedoresMVCContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Vendedores> Vendedores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        if (!optionsBuilder.IsConfigured)
    {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
  //      => optionsBuilder.UseSqlServer("Server=LAPTOP-G5KJU60G;Database=VendedoresMVC;User Id=yafreisi;Password=1234;TrustServerCertificate=True;");
    }
}
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vendedores>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vendedor__3214EC07897DFD72");

            entity.ToTable("Vendedores", "dbo");

            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PorcentajeComision).HasColumnType("decimal(5, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
