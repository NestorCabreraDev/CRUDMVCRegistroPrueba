using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUDMVCRegistroPrueba.Models;

public partial class RegistroPruebaContext : DbContext
{
    public RegistroPruebaContext()
    {
    }

    public RegistroPruebaContext(DbContextOptions<RegistroPruebaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-6QOLBGL; Database=RegistroPrueba; User Id=JAVADEV; Password=1914; Encrypt=False; TrustServerCertificate=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__students__4D11D63C5D998EF2");

            entity.ToTable("students");

            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.StudentAge).HasColumnName("studentAge");
            entity.Property(e => e.StudentCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("studentCountry");
            entity.Property(e => e.StudentName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("studentName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
