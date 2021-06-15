using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VehicleDB
{
    public partial class VehiclesContext : DbContext
    {
        public VehiclesContext()
        {
        }

        public VehiclesContext(DbContextOptions<VehiclesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vehicle> Vehicle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=Vehicles;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.VehicleColor).HasMaxLength(50);

                entity.Property(e => e.VehicleMake)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(50);
            });
        }
    }
}
