using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace examen2.Models;

public partial class Examen2Context : DbContext
{
    public Examen2Context()
    {
    }

    public Examen2Context(DbContextOptions<Examen2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC078A2A4E18");

            entity.ToTable("Producto");

            entity.Property(e => e.Id).HasColumnName("Id");
            entity.Property(e => e.Material).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
