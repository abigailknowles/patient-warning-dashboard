﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientWarningApp.Data.DbContexts;

namespace PatientWarningApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211122185142_DBInit")]
    partial class DBInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("PatientWarningApp.Data.Entities.PatientAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<sbyte>("IsAdmin")
                        .HasColumnType("tinyint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PractitionerId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK_Accounts");

                    b.HasIndex("PractitionerId");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("Idx_Username");

                    b.ToTable("PatientAccounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Patient1@example.com",
                            IsAdmin = (sbyte)0,
                            Password = "changeMe",
                            PatientId = 0,
                            PractitionerId = 0,
                            Username = "Username"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Patient1@example.com",
                            IsAdmin = (sbyte)0,
                            Password = "changeMe",
                            PatientId = 0,
                            PractitionerId = 0,
                            Username = "Username"
                        });
                });

            modelBuilder.Entity("PatientWarningApp.Data.Entities.PractitionerAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<sbyte>("IsAdmin")
                        .HasColumnType("tinyint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK_Accounts");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("Idx_Username");

                    b.ToTable("PractitionerAccounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "richardsi@example.com",
                            IsAdmin = (sbyte)1,
                            Password = "richardsi",
                            Username = "richardsi"
                        });
                });

            modelBuilder.Entity("PatientWarningApp.Data.Entities.PatientAccount", b =>
                {
                    b.HasOne("PatientWarningApp.Data.Entities.PractitionerAccount", "Practitioner")
                        .WithMany("PatientAccounts")
                        .HasForeignKey("PractitionerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Practitioner");
                });

            modelBuilder.Entity("PatientWarningApp.Data.Entities.PractitionerAccount", b =>
                {
                    b.Navigation("PatientAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}