using System;
using System.Linq;
using GenericRepository;
using NUnit.Framework;

namespace GenericRepositoryTests
{
    [TestFixture]
    public class QueryFixture
    {
        private IRepository<Release> _repository;

        [SetUp]
        public void Setup()
        {
            var factory = new ConnectionFactory();
            _repository = new Repository<Release>(factory.CreateContext(true));
        }

        [Test]
        public void CanQueryForBeatlesAlbums()
        {
            // Act
            var albums = _repository.Filter()
                .Where(x => x.Artist.Name == "The Beatles")
                .ToList();

            // Assert
            Assert.That(albums.Any(x => x.Name.Equals("Abbey Road")), Is.True);
            Assert.That(albums.Any(x => x.Name.Equals("(What''s the story) Morning Glory")), Is.False);
        }

        [Test]
        public void CanQueryForOasisSingles() {
        }

        [Test]
        public void CanQueryForOasisBSidesFromThe90s()
        {
            // Act

            // Assert
        }
    }
}
