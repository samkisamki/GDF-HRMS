﻿// <auto-generated />
using System;
using GDF_HRMS_v1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GDF_HRMS_v1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210526204159_enddatefix")]
    partial class enddatefix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("GDF_HRMS_v1.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Ctry")
                        .HasColumnType("int");

                    b.Property<int?>("EId")
                        .HasColumnType("int");

                    b.Property<string>("Lot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Reg")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Village")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Ctry");

                    b.HasIndex("EId");

                    b.HasIndex("Reg");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.CareerHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<int?>("EId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PosId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DeptId");

                    b.HasIndex("EId");

                    b.HasIndex("PosId");

                    b.ToTable("CareerHistories");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.EmployeePI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HNumber")
                        .HasColumnType("int");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MId")
                        .HasColumnType("int");

                    b.Property<int?>("NId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("NidNumber")
                        .HasColumnType("int");

                    b.Property<string>("Oname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RId")
                        .HasColumnType("int");

                    b.Property<int>("RNumber")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TinNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EId");

                    b.HasIndex("MId");

                    b.HasIndex("NId");

                    b.HasIndex("RId");

                    b.ToTable("EmployeePIs");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Ethnicity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ethnicities");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.MaritalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaritalStatuses");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Religion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Religions");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Address", b =>
                {
                    b.HasOne("GDF_HRMS_v1.Models.Country", "Country")
                        .WithMany("Addresses")
                        .HasForeignKey("Ctry");

                    b.HasOne("GDF_HRMS_v1.Models.EmployeePI", "EmployeePI")
                        .WithMany("Addresses")
                        .HasForeignKey("EId");

                    b.HasOne("GDF_HRMS_v1.Models.Region", "Region")
                        .WithMany("Addresses")
                        .HasForeignKey("Reg");

                    b.Navigation("Country");

                    b.Navigation("EmployeePI");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.CareerHistory", b =>
                {
                    b.HasOne("GDF_HRMS_v1.Models.Department", "Department")
                        .WithMany("CareerHistorys")
                        .HasForeignKey("DeptId");

                    b.HasOne("GDF_HRMS_v1.Models.EmployeePI", "EmployeePI")
                        .WithMany("CareerHistories")
                        .HasForeignKey("EId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GDF_HRMS_v1.Models.Position", "Position")
                        .WithMany("CareerHistorys")
                        .HasForeignKey("PosId");

                    b.Navigation("Department");

                    b.Navigation("EmployeePI");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.EmployeePI", b =>
                {
                    b.HasOne("GDF_HRMS_v1.Models.Ethnicity", "Ethnicity")
                        .WithMany("EmployeePIs")
                        .HasForeignKey("EId");

                    b.HasOne("GDF_HRMS_v1.Models.MaritalStatus", "MaritalStatus")
                        .WithMany("EmployeePIs")
                        .HasForeignKey("MId");

                    b.HasOne("GDF_HRMS_v1.Models.Nationality", "Nationality")
                        .WithMany("EmployeePIs")
                        .HasForeignKey("NId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GDF_HRMS_v1.Models.Religion", "Religion")
                        .WithMany("EmployeePIs")
                        .HasForeignKey("RId");

                    b.Navigation("Ethnicity");

                    b.Navigation("MaritalStatus");

                    b.Navigation("Nationality");

                    b.Navigation("Religion");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Country", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Department", b =>
                {
                    b.Navigation("CareerHistorys");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.EmployeePI", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("CareerHistories");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Ethnicity", b =>
                {
                    b.Navigation("EmployeePIs");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.MaritalStatus", b =>
                {
                    b.Navigation("EmployeePIs");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Nationality", b =>
                {
                    b.Navigation("EmployeePIs");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Position", b =>
                {
                    b.Navigation("CareerHistorys");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Region", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("GDF_HRMS_v1.Models.Religion", b =>
                {
                    b.Navigation("EmployeePIs");
                });
#pragma warning restore 612, 618
        }
    }
}
