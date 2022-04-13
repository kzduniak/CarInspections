using System;
using System.Collections.Generic;
using CarInspections.Api.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CarInspections.Api.Entities
{
    public partial class CarInspectionsContext : DbContext
    {
        public CarInspectionsContext()
        {
        }

        public CarInspectionsContext(DbContextOptions<CarInspectionsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<CarInspection> CarInspections { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");

                entity.HasIndex(e => e.RegistrationNumber, "Car_RegistrationNumber_key")
                    .IsUnique();

                entity.Property(e => e.Brand).HasMaxLength(100);

                entity.Property(e => e.Model).HasMaxLength(100);

                entity.Property(e => e.RegistrationNumber).HasMaxLength(9);
            });

            modelBuilder.Entity<CarInspection>(entity =>
            {
                entity.ToTable("CarInspection");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.CarInspections)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_car");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
