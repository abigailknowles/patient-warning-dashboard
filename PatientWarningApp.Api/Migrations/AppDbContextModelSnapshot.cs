﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatientWarningApp.Api.Shared.Contexts;

namespace PatientWarningApp.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("PatientWarningApp.Api.Media.Entities.MediaEntity", b =>
                {
                    b.Property<int>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MediaId")
                        .HasName("PK_Media");

                    b.ToTable("MediaEntity");
                });

            modelBuilder.Entity("PatientWarningApp.Api.MedicalRecords.Entities.MedicalRecordEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext");

                    b.Property<string>("SeizureFrequencies")
                        .HasColumnType("longtext");

                    b.Property<string>("SeizureTimes")
                        .HasColumnType("longtext");

                    b.Property<string>("SeizureTriggers")
                        .HasColumnType("longtext");

                    b.Property<string>("SeizureTypes")
                        .HasColumnType("longtext");

                    b.Property<string>("SideEffects")
                        .HasColumnType("longtext");

                    b.Property<string>("StartDate")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("PatientWarningApp.Api.Patient.Entities.PatientEntity", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PatientId")
                        .HasName("PK_Patients");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PatientWarningApp.Api.PatientAccount.Entities.PatientAccountEntity", b =>
                {
                    b.Property<int>("PatientAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<sbyte>("IsAdmin")
                        .HasColumnType("tinyint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int?>("PractitionerAccountEntityPractitionerAccountId")
                        .HasColumnType("int");

                    b.Property<int>("PractitionerAccountId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PatientAccountId")
                        .HasName("PK_PatientAccounts");

                    b.HasIndex("PractitionerAccountEntityPractitionerAccountId");

                    b.ToTable("PatientAccounts");
                });

            modelBuilder.Entity("PatientWarningApp.Api.Practitioner.Entities.PractitionerEntity", b =>
                {
                    b.Property<int>("PractitionerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PractitionerId")
                        .HasName("PK_Practitioners");

                    b.HasIndex("FirstName")
                        .HasDatabaseName("Idx_FirstName");

                    b.HasIndex("LastName")
                        .HasDatabaseName("Idx_LastName");

                    b.ToTable("Practitioners");
                });

            modelBuilder.Entity("PatientWarningApp.Api.PractitionerAccount.Entities.PractitionerAccountEntity", b =>
                {
                    b.Property<int>("PractitionerAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<sbyte>("IsAdmin")
                        .HasColumnType("tinyint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PractitionerAccountId")
                        .HasName("PK_PractitionerAccounts");

                    b.ToTable("PractitionerAccounts");
                });

            modelBuilder.Entity("PatientWarningApp.Api.ReviewedMedia.Entities.ReviewedMediaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EpilepsyRating")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SeizureTriggerTimes")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .HasName("PK_ReviewedMedia");

                    b.ToTable("ReviewedMediaEntity");
                });

            modelBuilder.Entity("PatientWarningApp.Api.PatientAccount.Entities.PatientAccountEntity", b =>
                {
                    b.HasOne("PatientWarningApp.Api.PractitionerAccount.Entities.PractitionerAccountEntity", null)
                        .WithMany("PatientAccounts")
                        .HasForeignKey("PractitionerAccountEntityPractitionerAccountId");
                });

            modelBuilder.Entity("PatientWarningApp.Api.PractitionerAccount.Entities.PractitionerAccountEntity", b =>
                {
                    b.Navigation("PatientAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
