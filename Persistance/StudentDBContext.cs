using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentSystem.Models
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

        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<Advisor> Advisor { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<MajAdv> MajAdv { get; set; }
        public virtual DbSet<Major> Major { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<StdAct> StdAct { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=Student;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.ActCode)
                    .HasName("activity_act_code_pk");

                entity.ToTable("activity");

                entity.Property(e => e.ActCode)
                    .HasColumnName("act_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ActFee)
                    .HasColumnName("act_fee")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ActName)
                    .HasColumnName("act_name")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Advisor>(entity =>
            {
                entity.HasKey(e => e.AdvCode)
                    .HasName("advisor_adv_code_pk");

                entity.ToTable("advisor");

                entity.Property(e => e.AdvCode)
                    .HasColumnName("adv_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AdvFname)
                    .HasColumnName("adv_fname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdvLname)
                    .HasColumnName("adv_lname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdvPhone)
                    .HasColumnName("adv_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SchCode)
                    .HasColumnName("sch_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.SchCodeNavigation)
                    .WithMany(p => p.Advisor)
                    .HasForeignKey(d => d.SchCode)
                    .HasConstraintName("advisor_sch_code_fk");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptCode)
                    .HasName("department_dept_code_pk");

                entity.ToTable("department");

                entity.Property(e => e.DeptCode)
                    .HasColumnName("dept_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DeptName)
                    .HasColumnName("dept_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptPhone)
                    .HasColumnName("dept_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FacCode)
                    .HasColumnName("fac_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.FacCodeNavigation)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.FacCode)
                    .HasConstraintName("department_fac_code_fk");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasKey(e => e.FacCode)
                    .HasName("faculty_fac_code_pk");

                entity.ToTable("faculty");

                entity.Property(e => e.FacCode)
                    .HasColumnName("fac_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FacFname)
                    .HasColumnName("fac_fname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FacGend)
                    .HasColumnName("fac_gend")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FacLname)
                    .HasColumnName("fac_lname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FacPhone)
                    .HasColumnName("fac_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SchCode)
                    .HasColumnName("sch_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.SchCodeNavigation)
                    .WithMany(p => p.Faculty)
                    .HasForeignKey(d => d.SchCode)
                    .HasConstraintName("faculty_sch_code_fk");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.StdCode)
                    .HasName("grade_std_code_pk");

                entity.ToTable("grade");

                entity.Property(e => e.StdCode)
                    .HasColumnName("std_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.GrAvg).HasColumnName("gr_avg");

                entity.Property(e => e.GrHw).HasColumnName("gr_hw");

                entity.Property(e => e.GrLg)
                    .HasColumnName("gr_lg")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.GrPr).HasColumnName("gr_pr");

                entity.Property(e => e.GrT1).HasColumnName("gr_t1");

                entity.Property(e => e.GrT2).HasColumnName("gr_t2");

                entity.Property(e => e.StdFname)
                    .IsRequired()
                    .HasColumnName("std_fname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StdLname)
                    .IsRequired()
                    .HasColumnName("std_lname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.StdCodeNavigation)
                    .WithOne(p => p.Grade)
                    .HasForeignKey<Grade>(d => d.StdCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grade_std_code_fk");
            });

            modelBuilder.Entity<MajAdv>(entity =>
            {
                entity.HasKey(e => new { e.MajCode, e.AdvCode })
                    .HasName("maj_adv_maj_code_adv_code_cpk");

                entity.ToTable("maj_adv");

                entity.Property(e => e.MajCode)
                    .HasColumnName("maj_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdvCode)
                    .HasColumnName("adv_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MajAdvLevel)
                    .HasColumnName("maj_adv_level")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.HasOne(d => d.AdvCodeNavigation)
                    .WithMany(p => p.MajAdv)
                    .HasForeignKey(d => d.AdvCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("maj_adv_adv_code_fk");

                entity.HasOne(d => d.MajCodeNavigation)
                    .WithMany(p => p.MajAdv)
                    .HasForeignKey(d => d.MajCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("maj_adv_maj_code_fk");
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.HasKey(e => e.MajCode)
                    .HasName("major_maj_code_pk");

                entity.ToTable("major");

                entity.Property(e => e.MajCode)
                    .HasColumnName("maj_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MajDesc)
                    .HasColumnName("maj_desc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SchCode)
                    .HasColumnName("sch_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.SchCodeNavigation)
                    .WithMany(p => p.Major)
                    .HasForeignKey(d => d.SchCode)
                    .HasConstraintName("major_sch_code_fk");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.SchCode)
                    .HasName("school_sch_code_pk");

                entity.ToTable("school");

                entity.Property(e => e.SchCode)
                    .HasColumnName("sch_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SchDeanName)
                    .HasColumnName("sch_dean_name")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SchName)
                    .HasColumnName("sch_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchPhone)
                    .HasColumnName("sch_phone")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StdAct>(entity =>
            {
                entity.HasKey(e => new { e.StdCode, e.ActCode })
                    .HasName("std_act_std_code_act_code_cpk");

                entity.ToTable("std_act");

                entity.Property(e => e.StdCode)
                    .HasColumnName("std_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ActCode)
                    .HasColumnName("act_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StdActJoined)
                    .HasColumnName("std_act_joined")
                    .HasColumnType("date");

                entity.Property(e => e.StdActNum).HasColumnName("std_act_num");

                entity.HasOne(d => d.ActCodeNavigation)
                    .WithMany(p => p.StdAct)
                    .HasForeignKey(d => d.ActCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("std_act_act_code_fk");

                entity.HasOne(d => d.StdCodeNavigation)
                    .WithMany(p => p.StdAct)
                    .HasForeignKey(d => d.StdCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("std_act_std_code_fk");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StdCode)
                    .HasName("student_std_code_pk");

                entity.ToTable("student");

                entity.Property(e => e.StdCode)
                    .HasColumnName("std_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.MajCode)
                    .HasColumnName("maj_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StdDob)
                    .HasColumnName("std_dob")
                    .HasColumnType("date");

                entity.Property(e => e.StdFname)
                    .IsRequired()
                    .HasColumnName("std_fname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StdGend)
                    .HasColumnName("std_gend")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StdLname)
                    .IsRequired()
                    .HasColumnName("std_lname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.MajCodeNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.MajCode)
                    .HasConstraintName("student_maj_code_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
