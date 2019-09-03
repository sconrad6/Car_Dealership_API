using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Car_Dealership_API.Models
{
    public partial class CarDbContext : DbContext
    {
        public CarDbContext()
        {
        }

        public CarDbContext(DbContextOptions<CarDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=CarDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(25);

                entity.Property(e => e.Make)
                    .HasColumnName("make")
                    .HasMaxLength(26);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(26);

                entity.Property(e => e.Year).HasColumnName("year");
            });
        }
    }
}
