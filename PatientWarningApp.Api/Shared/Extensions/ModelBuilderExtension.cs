﻿using Microsoft.EntityFrameworkCore;
using PatientWarningApp.Api.Media.Entities;
using PatientWarningApp.Api.Patient.Entities;
using PatientWarningApp.Api.PatientAccount.Entities;
using PatientWarningApp.Api.Practitioner.Entities;
using PatientWarningApp.Api.PractitionerAccount.Entities;
using PatientWarningApp.Api.ReviewedMedia.Entities;

namespace PatientWarningApp.Api.Shared.Extensions
{
    public static class ModelBuilderExtension 
    {
        public static void SeedPatientAccounts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientAccountEntity>().HasData(
                new PatientAccountEntity
                {
                    PatientAccountId = 1,
                    Email = "abigailknowles@patientportal.com",
                    IsAdmin = false,
                    Password = "password",
                    Username = "abigailknowles01"
                }
            );

            modelBuilder.Entity<PatientAccountEntity>().HasData(
                new PatientAccountEntity
                {
                    PatientAccountId = 2,
                    Email = "bethanyknowles@patientportal.com",
                    IsAdmin = false,
                    Password = "password",
                    Username = "bethanyknowles"
                }
            );
        }

        public static void SeedPractitionerAccounts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PractitionerAccountEntity>().HasData(
                new PractitionerAccountEntity
                {
                    PractitionerAccountId = 1,
                    Username = "nathanknowles",
                    Password = "password",
                    IsAdmin = true,
                    Email = "nathanknowles@patientportal.com",
                }
            );
        }
        public static void SetEntityMappings(this ModelBuilder modelBuilder)
        {
            // Map entities to tables  
            modelBuilder.Entity<PractitionerAccountEntity>().ToTable("PractitionerAccounts");
            modelBuilder.Entity<PatientAccountEntity>().ToTable("PatientAccounts");
            modelBuilder.Entity<PractitionerEntity>().ToTable("Practitioners");
            modelBuilder.Entity<PatientEntity>().ToTable("Patients");
            modelBuilder.Entity<MediaEntity>().ToTable("Media");
            modelBuilder.Entity<ReviewedMediaEntity>().ToTable("ReviewedMedia");

            // Configure Primary Keys  
            modelBuilder.Entity<PractitionerAccountEntity>().HasKey(ug => ug.PractitionerAccountId).HasName("PK_PractitionerAccounts");
            modelBuilder.Entity<PatientAccountEntity>().HasKey(ug => ug.PatientAccountId).HasName("PK_PatientAccounts");
            modelBuilder.Entity<PractitionerEntity>().HasKey(ug => ug.PractitionerId).HasName("PK_Practitioners");
            modelBuilder.Entity<PatientEntity>().HasKey(ug => ug.PatientId).HasName("PK_Patients");
            modelBuilder.Entity<MediaEntity>().HasKey(ug => ug.Id).HasName("PK_Media");
            modelBuilder.Entity<ReviewedMediaEntity>().HasKey(ug => ug.Id).HasName("PK_ReviewedMedia");

            // Configure indexes 
            modelBuilder.Entity<PractitionerEntity>().HasIndex(p => p.FirstName).HasDatabaseName("Idx_FirstName");
            modelBuilder.Entity<PractitionerEntity>().HasIndex(p => p.LastName).HasDatabaseName("Idx_LastName");

            // Configure columns  
            modelBuilder.Entity<PractitionerAccountEntity>().Property(ug => ug.PractitionerAccountId).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<PractitionerAccountEntity>().Property(ug => ug.PractitionerId).HasColumnType("int");
            modelBuilder.Entity<PractitionerAccountEntity>().Property(ug => ug.Email).HasColumnType("nvarchar(255)").IsRequired();
            modelBuilder.Entity<PractitionerAccountEntity>().Property(ug => ug.Password).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<PractitionerAccountEntity>().Property(ug => ug.Username).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<PractitionerAccountEntity>().Property(ug => ug.IsAdmin).HasColumnType("tinyint").IsRequired();

            modelBuilder.Entity<PatientAccountEntity>().Property(ug => ug.Email).HasColumnType("nvarchar(255)").IsRequired();
            modelBuilder.Entity<PatientAccountEntity>().Property(ug => ug.Password).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<PatientAccountEntity>().Property(ug => ug.Username).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<PatientAccountEntity>().Property(ug => ug.IsAdmin).HasColumnType("tinyint").IsRequired();
            modelBuilder.Entity<PatientAccountEntity>().Property(ug => ug.PatientAccountId).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<PatientAccountEntity>().Property(ug => ug.PatientId).HasColumnType("int");

            modelBuilder.Entity<PractitionerEntity>().Property(ug => ug.PractitionerId).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<PractitionerEntity>().Property(ug => ug.Title).HasColumnType("nvarchar(20)").IsRequired();
            modelBuilder.Entity<PractitionerEntity>().Property(ug => ug.FirstName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<PractitionerEntity>().Property(ug => ug.LastName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<PractitionerEntity>().Property(ug => ug.MobileNumber).HasColumnType("nvarchar(13)").IsRequired();
            modelBuilder.Entity<PractitionerEntity>().Property(ug => ug.DOB).HasColumnType("nvarchar(10)").IsRequired();
            modelBuilder.Entity<PractitionerEntity>().Property(ug => ug.Age).HasColumnType("int").IsRequired();
            modelBuilder.Entity<PractitionerEntity>().Property(ug => ug.Gender).HasColumnType("nvarchar(30)").IsRequired();
            modelBuilder.Entity<PractitionerEntity>().Property(ug => ug.Address).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<PractitionerEntity>().Property(ug => ug.Postcode).HasColumnType("nvarchar(10)").IsRequired();

            modelBuilder.Entity<PatientEntity>().Property(ug => ug.PatientId).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<PatientEntity>().Property(ug => ug.Title).HasColumnType("nvarchar(20)").IsRequired();
            modelBuilder.Entity<PatientEntity>().Property(ug => ug.FirstName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<PatientEntity>().Property(ug => ug.LastName).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<PatientEntity>().Property(ug => ug.MobileNumber).HasColumnType("nvarchar(13)").IsRequired();
            modelBuilder.Entity<PatientEntity>().Property(ug => ug.DOB).HasColumnType("nvarchar(10)").IsRequired();
            modelBuilder.Entity<PatientEntity>().Property(ug => ug.Age).HasColumnType("int").IsRequired();
            modelBuilder.Entity<PatientEntity>().Property(ug => ug.Gender).HasColumnType("nvarchar(30)").IsRequired();
            modelBuilder.Entity<PatientEntity>().Property(ug => ug.Address).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<PatientEntity>().Property(ug => ug.Postcode).HasColumnType("nvarchar(10)").IsRequired();

            modelBuilder.Entity<MediaEntity>().Property(ug => ug.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<MediaEntity>().Property(ug => ug.Title).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<MediaEntity>().Property(ug => ug.Genre).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<MediaEntity>().Property(ug => ug.Director).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<MediaEntity>().Property(ug => ug.ReleaseDate).HasColumnType("nvarchar(200)").IsRequired();

            modelBuilder.Entity<ReviewedMediaEntity>().Property(ug => ug.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            modelBuilder.Entity<ReviewedMediaEntity>().Property(ug => ug.EpilepsyRating).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<ReviewedMediaEntity>().Property(ug => ug.SeizureTriggerTimes).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<ReviewedMediaEntity>().Property(ug => ug.Notes).HasColumnType("nvarchar(200)").IsRequired();

        }
    }
}
