using System;
using System.Linq;
using GenericRepository;
using NUnit.Framework;

namespace GenericRepositoryTests
{
    [TestFixture]
    public class SongQueryFixture
    {
        private IRepository<Song> _repository;

        [SetUp]
        public void Setup()
        {
            var factory = new ConnectionFactory();
            _repository = new Repository<Song>(factory.CreateContext(true));
        }

        [Test]
        public void CanQueryForOasisBSidesFromThe90s()
        {
            // Act
            var songs = _repository.Filter()
                .Where(x => x.Release.ReleaseType == ReleaseType.Single)
                .Where(x => x.Release.Year > 1990 && x.Release.Year < 2000)
                .ToList();

            // Assert
            Assert.That(songs, Is.Not.Empty);
            Assert.That(songs.Any(x => x.Name.Equals("Round our Way", StringComparison.OrdinalIgnoreCase)), Is.True);

            // Not a 90s b-side
            Assert.That(songs.Any(x => x.Name.Equals("Just Gettings Older", StringComparison.OrdinalIgnoreCase)), Is.False);

            // Album track - not a b-side
            Assert.That(songs.Any(x => x.Name.Equals("Champagne Supernova", StringComparison.OrdinalIgnoreCase)), Is.False);
        }
    }
}
