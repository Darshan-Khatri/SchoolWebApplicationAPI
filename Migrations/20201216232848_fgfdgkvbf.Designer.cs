﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.Models;

namespace StudentSystem.Migrations
{
    [DbContext(typeof(StudentDBContext))]
    [Migration("20201216232848_fgfdgkvbf")]
    partial class fgfdgkvbf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentSystem.Models.Activity", b =>
                {
                    b.Property<string>("ActCode")
                        .HasColumnName("act_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<decimal?>("ActFee")
                        .HasColumnName("act_fee")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<string>("ActName")
                        .HasColumnName("act_name")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("ActCode")
                        .HasName("activity_act_code_pk");

                    b.ToTable("activity");
                });

            modelBuilder.Entity("StudentSystem.Models.Advisor", b =>
                {
                    b.Property<string>("AdvCode")
                        .HasColumnName("adv_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("AdvFname")
                        .HasColumnName("adv_fname")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("AdvLname")
                        .HasColumnName("adv_lname")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("AdvPhone")
                        .HasColumnName("adv_phone")
                        .HasColumnType("varchar(12)")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.Property<string>("SchCode")
                        .HasColumnName("sch_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.HasKey("AdvCode")
                        .HasName("advisor_adv_code_pk");

                    b.HasIndex("SchCode");

                    b.ToTable("advisor");
                });

            modelBuilder.Entity("StudentSystem.Models.Department", b =>
                {
                    b.Property<string>("DeptCode")
                        .HasColumnName("dept_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("DeptName")
                        .HasColumnName("dept_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("DeptPhone")
                        .HasColumnName("dept_phone")
                        .HasColumnType("varchar(12)")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.Property<string>("FacCode")
                        .HasColumnName("fac_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.HasKey("DeptCode")
                        .HasName("department_dept_code_pk");

                    b.HasIndex("FacCode");

                    b.ToTable("department");
                });

            modelBuilder.Entity("StudentSystem.Models.Faculty", b =>
                {
                    b.Property<string>("FacCode")
                        .HasColumnName("fac_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("FacFname")
                        .HasColumnName("fac_fname")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("FacGend")
                        .HasColumnName("fac_gend")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("FacLname")
                        .HasColumnName("fac_lname")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("FacPhone")
                        .HasColumnName("fac_phone")
                        .HasColumnType("varchar(12)")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.Property<string>("SchCode")
                        .HasColumnName("sch_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.HasKey("FacCode")
                        .HasName("faculty_fac_code_pk");

                    b.HasIndex("SchCode");

                    b.ToTable("faculty");
                });

            modelBuilder.Entity("StudentSystem.Models.Grade", b =>
                {
                    b.Property<string>("StdCode")
                        .HasColumnName("std_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<int?>("GrAvg")
                        .HasColumnName("gr_avg")
                        .HasColumnType("int");

                    b.Property<int?>("GrHw")
                        .HasColumnName("gr_hw")
                        .HasColumnType("int");

                    b.Property<string>("GrLg")
                        .HasColumnName("gr_lg")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<int?>("GrPr")
                        .HasColumnName("gr_pr")
                        .HasColumnType("int");

                    b.Property<int?>("GrT1")
                        .HasColumnName("gr_t1")
                        .HasColumnType("int");

                    b.Property<int?>("GrT2")
                        .HasColumnName("gr_t2")
                        .HasColumnType("int");

                    b.Property<string>("StdFname")
                        .IsRequired()
                        .HasColumnName("std_fname")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("StdLname")
                        .IsRequired()
                        .HasColumnName("std_lname")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("StdCode")
                        .HasName("grade_std_code_pk");

                    b.ToTable("grade");
                });

            modelBuilder.Entity("StudentSystem.Models.MajAdv", b =>
                {
                    b.Property<string>("MajCode")
                        .HasColumnName("maj_code")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("AdvCode")
                        .HasColumnName("adv_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("MajAdvLevel")
                        .HasColumnName("maj_adv_level")
                        .HasColumnType("varchar(12)")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.HasKey("MajCode", "AdvCode")
                        .HasName("maj_adv_maj_code_adv_code_cpk");

                    b.HasIndex("AdvCode");

                    b.ToTable("maj_adv");
                });

            modelBuilder.Entity("StudentSystem.Models.Major", b =>
                {
                    b.Property<string>("MajCode")
                        .HasColumnName("maj_code")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("MajDesc")
                        .HasColumnName("maj_desc")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("SchCode")
                        .HasColumnName("sch_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.HasKey("MajCode")
                        .HasName("major_maj_code_pk");

                    b.HasIndex("SchCode");

                    b.ToTable("major");
                });

            modelBuilder.Entity("StudentSystem.Models.School", b =>
                {
                    b.Property<string>("SchCode")
                        .HasColumnName("sch_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("SchDeanName")
                        .HasColumnName("sch_dean_name")
                        .HasColumnType("varchar(35)")
                        .HasMaxLength(35)
                        .IsUnicode(false);

                    b.Property<string>("SchName")
                        .HasColumnName("sch_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("SchPhone")
                        .HasColumnName("sch_phone")
                        .HasColumnType("varchar(12)")
                        .HasMaxLength(12)
                        .IsUnicode(false);

                    b.HasKey("SchCode")
                        .HasName("school_sch_code_pk");

                    b.ToTable("school");
                });

            modelBuilder.Entity("StudentSystem.Models.StdAct", b =>
                {
                    b.Property<string>("StdCode")
                        .HasColumnName("std_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("ActCode")
                        .HasColumnName("act_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<DateTime?>("StdActJoined")
                        .HasColumnName("std_act_joined")
                        .HasColumnType("date");

                    b.Property<int?>("StdActNum")
                        .HasColumnName("std_act_num")
                        .HasColumnType("int");

                    b.HasKey("StdCode", "ActCode")
                        .HasName("std_act_std_code_act_code_cpk");

                    b.HasIndex("ActCode");

                    b.ToTable("std_act");
                });

            modelBuilder.Entity("StudentSystem.Models.Student", b =>
                {
                    b.Property<string>("StdCode")
                        .HasColumnName("std_code")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("MajCode")
                        .HasColumnName("maj_code")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<DateTime?>("StdDob")
                        .HasColumnName("std_dob")
                        .HasColumnType("date");

                    b.Property<string>("StdFname")
                        .IsRequired()
                        .HasColumnName("std_fname")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("StdGend")
                        .IsRequired()
                        .HasColumnName("std_gend")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("StdLname")
                        .IsRequired()
                        .HasColumnName("std_lname")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("StdMname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StdCode")
                        .HasName("student_std_code_pk");

                    b.HasIndex("MajCode");

                    b.ToTable("student");
                });

            modelBuilder.Entity("StudentSystem.Models.Advisor", b =>
                {
                    b.HasOne("StudentSystem.Models.School", "SchCodeNavigation")
                        .WithMany("Advisor")
                        .HasForeignKey("SchCode")
                        .HasConstraintName("advisor_sch_code_fk");
                });

            modelBuilder.Entity("StudentSystem.Models.Department", b =>
                {
                    b.HasOne("StudentSystem.Models.Faculty", "FacCodeNavigation")
                        .WithMany("Department")
                        .HasForeignKey("FacCode")
                        .HasConstraintName("department_fac_code_fk");
                });

            modelBuilder.Entity("StudentSystem.Models.Faculty", b =>
                {
                    b.HasOne("StudentSystem.Models.School", "SchCodeNavigation")
                        .WithMany("Faculty")
                        .HasForeignKey("SchCode")
                        .HasConstraintName("faculty_sch_code_fk");
                });

            modelBuilder.Entity("StudentSystem.Models.Grade", b =>
                {
                    b.HasOne("StudentSystem.Models.Student", "StdCodeNavigation")
                        .WithOne("Grade")
                        .HasForeignKey("StudentSystem.Models.Grade", "StdCode")
                        .HasConstraintName("grade_std_code_fk")
                        .IsRequired();
                });

            modelBuilder.Entity("StudentSystem.Models.MajAdv", b =>
                {
                    b.HasOne("StudentSystem.Models.Advisor", "AdvCodeNavigation")
                        .WithMany("MajAdv")
                        .HasForeignKey("AdvCode")
                        .HasConstraintName("maj_adv_adv_code_fk")
                        .IsRequired();

                    b.HasOne("StudentSystem.Models.Major", "MajCodeNavigation")
                        .WithMany("MajAdv")
                        .HasForeignKey("MajCode")
                        .HasConstraintName("maj_adv_maj_code_fk")
                        .IsRequired();
                });

            modelBuilder.Entity("StudentSystem.Models.Major", b =>
                {
                    b.HasOne("StudentSystem.Models.School", "SchCodeNavigation")
                        .WithMany("Major")
                        .HasForeignKey("SchCode")
                        .HasConstraintName("major_sch_code_fk");
                });

            modelBuilder.Entity("StudentSystem.Models.StdAct", b =>
                {
                    b.HasOne("StudentSystem.Models.Activity", "ActCodeNavigation")
                        .WithMany("StdAct")
                        .HasForeignKey("ActCode")
                        .HasConstraintName("std_act_act_code_fk")
                        .IsRequired();

                    b.HasOne("StudentSystem.Models.Student", "StdCodeNavigation")
                        .WithMany("StdAct")
                        .HasForeignKey("StdCode")
                        .HasConstraintName("std_act_std_code_fk")
                        .IsRequired();
                });

            modelBuilder.Entity("StudentSystem.Models.Student", b =>
                {
                    b.HasOne("StudentSystem.Models.Major", "MajCodeNavigation")
                        .WithMany("Student")
                        .HasForeignKey("MajCode")
                        .HasConstraintName("student_maj_code_fk");
                });
#pragma warning restore 612, 618
        }
    }
}
