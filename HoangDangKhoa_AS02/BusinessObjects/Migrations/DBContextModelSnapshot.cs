﻿// <auto-generated />
using System;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusinessObjects.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessObjects.CompanyProject", b =>
                {
                    b.Property<int>("CompanyProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyProjectID"));

                    b.Property<string>("ProjectDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyProjectID");

                    b.ToTable("CompanyProjects");

                    b.HasData(
                        new
                        {
                            CompanyProjectID = 1,
                            ProjectDescription = "Project 1 Description",
                            ProjectName = "Project 1"
                        },
                        new
                        {
                            CompanyProjectID = 2,
                            ProjectDescription = "Project 2 Description",
                            ProjectName = "Project 2"
                        },
                        new
                        {
                            CompanyProjectID = 3,
                            ProjectDescription = "Project 3 Description",
                            ProjectName = "Project 3"
                        });
                });

            modelBuilder.Entity("BusinessObjects.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("DepartmentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentID = 1,
                            DepartmentDescription = "Department 1 Description",
                            DepartmentName = "Department 1"
                        },
                        new
                        {
                            DepartmentID = 2,
                            DepartmentDescription = "Department 2 Description",
                            DepartmentName = "Department 2"
                        },
                        new
                        {
                            DepartmentID = 3,
                            DepartmentDescription = "Department 3 Description",
                            DepartmentName = "Department 3"
                        });
                });

            modelBuilder.Entity("BusinessObjects.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("EmailAddress")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Address = "Address 1",
                            DepartmentID = 1,
                            EmailAddress = "admin@gmail.com",
                            FullName = "Administrator",
                            Password = "123456",
                            Role = 1,
                            Skills = "Manager",
                            Status = 1,
                            Telephone = "123456789"
                        },
                        new
                        {
                            EmployeeID = 2,
                            Address = "Address 2",
                            DepartmentID = 1,
                            EmailAddress = "employee@gmail.com",
                            FullName = "Employee",
                            Password = "123456",
                            Role = 2,
                            Skills = "Works",
                            Status = 1,
                            Telephone = "123456789"
                        });
                });

            modelBuilder.Entity("BusinessObjects.ParticipatingProject", b =>
                {
                    b.Property<int>("CompanyProjectID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectRole")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CompanyProjectID", "EmployeeID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("ParticipatingProjects");

                    b.HasData(
                        new
                        {
                            CompanyProjectID = 1,
                            EmployeeID = 2,
                            EndDate = new DateTime(2023, 6, 10, 10, 21, 55, 365, DateTimeKind.Local).AddTicks(9253),
                            ProjectRole = 1,
                            StartDate = new DateTime(2023, 6, 9, 10, 21, 55, 365, DateTimeKind.Local).AddTicks(9240)
                        });
                });

            modelBuilder.Entity("BusinessObjects.Employee", b =>
                {
                    b.HasOne("BusinessObjects.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("BusinessObjects.ParticipatingProject", b =>
                {
                    b.HasOne("BusinessObjects.CompanyProject", "CompanyProject")
                        .WithMany("ParticipatingProjects")
                        .HasForeignKey("CompanyProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyProject");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BusinessObjects.CompanyProject", b =>
                {
                    b.Navigation("ParticipatingProjects");
                });
#pragma warning restore 612, 618
        }
    }
}
