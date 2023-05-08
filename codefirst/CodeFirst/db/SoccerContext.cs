using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.db;

public partial class SoccerContext : DbContext
{
    public SoccerContext()
    {
    }

    public SoccerContext(DbContextOptions<SoccerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Druzyna> Teams { get; set; }

    public virtual DbSet<Ligi> Leagues { get; set; }

    public virtual DbSet<Pilkarze> Players { get; set; }

    public virtual DbSet<Trener> Treners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-P6988Q7;Database=soccer;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Druzyna>(entity =>
        {
            entity.HasKey(e => e.IdDruzyny);

            entity.HasOne(d => d.IdTreneraNavigation).WithMany(p => p.Teams)
                .HasForeignKey(d => d.IdTrenera);
        });

        modelBuilder.Entity<Ligi>(entity =>
        {
            entity.HasKey(e => e.IdLigi);

            entity.HasOne(d => d.IdDruzynyNavigation).WithMany(p => p.Leagues)
                .HasForeignKey(d => d.IdDruzyny);
        });

        modelBuilder.Entity<Pilkarze>(entity =>
        {
            entity.HasKey(e => e.IdPilkarza);

            entity.HasOne(d => d.IdDruzynyNavigation).WithMany(p => p.Players)
                .HasForeignKey(d => d.IdDruzyny);
                
                
        });

        modelBuilder.Entity<Trener>(entity =>
        {
            entity.HasKey(e => e.IdTrenera);

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
