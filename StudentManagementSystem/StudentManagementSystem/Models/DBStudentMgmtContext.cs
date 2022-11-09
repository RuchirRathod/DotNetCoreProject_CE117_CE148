using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentManagementSystem.Models
{
    public partial class DBStudentMgmtContext : DbContext
    {
        public DBStudentMgmtContext()
        {
        }

        public DBStudentMgmtContext(DbContextOptions<DBStudentMgmtContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblclassRoom> TblclassRoom { get; set; }
        public virtual DbSet<Tblstudent> Tblstudent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=DBStudentMgmt; trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblclassRoom>(entity =>
            {
                entity.HasKey(e => e.IdCr)
                    .HasName("PK__TBLClass__B77390B163926977");

                entity.ToTable("TBLClassRoom");

                entity.Property(e => e.CreaterDateCr).HasColumnType("datetime");

                entity.Property(e => e.NameCr).HasMaxLength(255);
            });

            modelBuilder.Entity<Tblstudent>(entity =>
            {
                entity.HasKey(e => e.IdSt)
                    .HasName("PK__TBLStude__B77012ABF66DE0CF");

                entity.ToTable("TBLStudent");

                entity.Property(e => e.AddressSt).HasMaxLength(2000);

                entity.Property(e => e.BirthdatSt).HasColumnType("date");

                entity.Property(e => e.CreateDateSt).HasColumnType("datetime");

                entity.Property(e => e.NameSt).HasMaxLength(255);

                entity.HasOne(d => d.IdCrNavigation)
                    .WithMany(p => p.Tblstudent)
                    .HasForeignKey(d => d.IdCr)
                    .HasConstraintName("FK__TBLStudent__IdCr__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
