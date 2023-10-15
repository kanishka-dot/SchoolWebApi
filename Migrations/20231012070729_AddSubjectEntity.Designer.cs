﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolWebApi.Models;

#nullable disable

namespace SchoolWebApi.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20231012070729_AddSubjectEntity")]
    partial class AddSubjectEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolWebApi.Models.Classroom", b =>
                {
                    b.Property<int>("ClassroomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassroomId"));

                    b.Property<string>("ClassroomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ClassroomId");

                    b.HasIndex("ClassroomName")
                        .IsUnique();

                    b.ToTable("Classroom");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("Classroom")
                        .HasColumnType("int");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StudentDob")
                        .HasColumnType("Date");

                    b.Property<string>("StudentFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("Classroom");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SubjectId");

                    b.HasIndex("SubjectName")
                        .IsUnique();

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeacherFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.HasIndex("ContactNo", "Email")
                        .IsUnique();

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Student", b =>
                {
                    b.HasOne("SchoolWebApi.Models.Classroom", null)
                        .WithMany("Student")
                        .HasForeignKey("Classroom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SchoolWebApi.Models.Classroom", b =>
                {
                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
