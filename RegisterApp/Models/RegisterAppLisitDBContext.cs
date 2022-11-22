using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RegisterApp.Models
{
    public partial class RegisterAppLisitDBContext : DbContext
    {
        public RegisterAppLisitDBContext()
        {
        }

        public RegisterAppLisitDBContext(DbContextOptions<RegisterAppLisitDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=bdevelopment.net;Database=RegisterAppLisitDB;User=lisituser;Password=c84d18c1-145e-42aa-9694-fd0dceb66f7a;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Offic)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
