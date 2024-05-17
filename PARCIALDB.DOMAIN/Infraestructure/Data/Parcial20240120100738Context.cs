using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PARCIALDB.DOMAIN.Core.Entities;

namespace PARCIALDB.DOMAIN.Infraestructure.Data;

public partial class Parcial20240120100738Context : DbContext
{
    public Parcial20240120100738Context()
    {
    }

    public Parcial20240120100738Context(DbContextOptions<Parcial20240120100738Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Sport> Sport { get; set; }

    public virtual DbSet<Team> Team { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302498;Database=Parcial20240120100738;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sport>(entity =>
        {
            entity.Property(e => e.Country).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.FoundationDate).HasMaxLength(20);
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.Property(e => e.Country).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
