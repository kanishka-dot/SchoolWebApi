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
    [Migration("20231012055801_InitialSchoolDB")]
    partial class InitialSchoolDB
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
                    b.Property<int>("classroomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("classroomId"));

                    b.Property<string>("classroomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("classroomId");

                    b.HasIndex("classroomName")
                        .IsUnique();

                    b.ToTable("Classroom");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studentId"));

                    b.Property<int>("Classroom")
                        .HasColumnType("int");

                    b.Property<string>("contactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("studentDob")
                        .HasColumnType("Date");

                    b.Property<string>("studentFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("studentId");

                    b.HasIndex("Classroom");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Student", b =>
                {
                    b.HasOne("SchoolWebApi.Models.Classroom", "classroom")
                        .WithMany()
                        .HasForeignKey("Classroom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("classroom");
                });
#pragma warning restore 612, 618
        }
    }
}
