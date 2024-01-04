using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Student_DataAccess.StudentContext
{
    public partial class StudentDBContext : DbContext
    {
        public StudentDBContext()
        {
        }

        public StudentDBContext(DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<Vlink> Vlinks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HM2D5TM\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseId)
                    .HasMaxLength(100)
                    .HasColumnName("Course ID");

                entity.Property(e => e.CourseName).HasColumnName("Course Name");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(100)
                    .HasColumnName("Student ID");

                entity.Property(e => e.FatherName).HasColumnName("Father Name");

                entity.Property(e => e.StudentName).HasColumnName("Student Name");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.SubjectId)
                    .HasMaxLength(100)
                    .HasColumnName("Subject ID");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(100)
                    .HasColumnName("Course ID");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(100)
                    .HasColumnName("Course Name");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Subjects__Course__3A81B327");
            });

            modelBuilder.Entity<Vlink>(entity =>
            {
                entity.HasKey(e => e.VideoId)
                    .HasName("PK__VLinks__17595B368330ACEB");

                entity.ToTable("VLinks");

                entity.Property(e => e.VideoId)
                    .HasMaxLength(100)
                    .HasColumnName("Video ID");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(100)
                    .HasColumnName("Course ID");

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(100)
                    .HasColumnName("Subject ID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Vlinks)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__VLinks__Course I__3E52440B");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Vlinks)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__VLinks__Subject __3D5E1FD2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
