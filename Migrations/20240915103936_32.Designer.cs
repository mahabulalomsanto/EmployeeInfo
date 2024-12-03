﻿// <auto-generated />
using System;
using EmployeeInfo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeInfo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240915103936_32")]
    partial class _32
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeInfo.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DOB")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "abul@gmail.com",
                            Mobile = "01714546489",
                            Name = "Abul Kalam"
                        },
                        new
                        {
                            Id = 2,
                            DOB = new DateTime(1983, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jobhaq@gmail.com",
                            Mobile = "01354748493",
                            Name = "Jobyda Haque"
                        },
                        new
                        {
                            Id = 3,
                            DOB = new DateTime(1999, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tanim@yahoo.com",
                            Mobile = "015698746312",
                            Name = "Tanim Shariar"
                        },
                        new
                        {
                            Id = 4,
                            DOB = new DateTime(2001, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nondi@hotmail.com",
                            Mobile = "01845693216",
                            Name = "Shubir Nondi"
                        },
                        new
                        {
                            Id = 5,
                            DOB = new DateTime(2000, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "afia@gmail.com",
                            Mobile = "01752146369",
                            Name = "Afia Khatun"
                        },
                        new
                        {
                            Id = 6,
                            DOB = new DateTime(1998, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tonima@yahoo.com",
                            Mobile = "017896544123",
                            Name = "Tonima Enam"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
