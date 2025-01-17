﻿using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using PatientWarningApp.Api.Media;
using PatientWarningApp.Api.Media.Entities;
using PatientWarningApp.Api.Shared.Contexts;

namespace PatientWarningApp.Tests.MediaTests
{
    public class MediaRepoTests
    {
        private MediaRepository _repository;
        private DbContextOptions<AppDbContext> _options;
        private AppDbContext _context;

        [SetUp]
        public void Setup()
        {
            _options = new DbContextOptionsBuilder<AppDbContext>()
            .EnableSensitiveDataLogging()
            .UseInMemoryDatabase(databaseName: "MediaListDatabase")
            .Options;

        }

        [TearDown]
        public void TearDown()
        {
           
        }

        [Test]
        public void CreateMediaRecord()
        {
            //Arrange
            var entity = new MediaEntity() {
                Id = 11,
                Title = "Shrek",
                Genre = "Family",
                Director="JK Rowling",
                ReleaseDate="08/08/2000"
            };

            //Act
            using var context = new AppDbContext(_options);
            _repository = new MediaRepository(context);

            var result = _repository.Create(entity);

            //Assert
            Assert.That(result.Id, Is.EqualTo(11));
            Assert.That(result.Title, Is.EqualTo("Shrek"));
        }

        [Test]
        public void DeleteMediaRecordById()
        {
            //Arrange
            var entity = new MediaEntity() { Id = 2 };
            using var context = _context = new AppDbContext(_options);
            _context.Media.Add(entity);
            _context.SaveChanges();
            _repository = new MediaRepository(_context);

            //Act
            var result = _repository.Delete(entity);
            var readResult = _repository.Read(entity.Id);

            //Assert
            Assert.That(result.Id, Is.EqualTo(2));
            Assert.That(readResult, Is.Null);
        }

        [Test]
        public void ReadMediaRecordById()
        {
            //Arrange
            var entity = new MediaEntity{ Id = 5 };
            using var context = new AppDbContext(_options);
            context.Media.Add(entity);
            context.SaveChanges();
            var mediaRepository = new MediaRepository(context);
            
            //Act
            var readResult = mediaRepository.Read(entity.Id);

            //Assert
            Assert.That(readResult.Id, Is.EqualTo(5));
        }

        [Test]
        public void UpdatePatientRecord()
        {
            //Arrange
            var entity = new MediaEntity()
            {
                Id = 7,
                Title = "Shrek",
                Genre = "Family",
                Director = "JK Rowling",
                ReleaseDate = "08/08/2000"
            };

            //Act
            using var context = new AppDbContext(_options);
            context.Media.Add(entity);
            context.SaveChanges();
            var mediaRepository = new MediaRepository(context);
            entity.Title = "Shrek 2";

            //Act
            mediaRepository.Update(entity);
            var result = mediaRepository.Read(entity.Id);
            //Assert
            Assert.That(result.Id, Is.EqualTo(7));
            Assert.That(result.Title, Is.EqualTo("Shrek 2"));
        }
    }
}
