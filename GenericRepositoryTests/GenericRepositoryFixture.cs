using System.Linq;
using GenericRepository;
using NUnit.Framework;

namespace Generic_Repository
{
    [TestFixture]
    public class Tests
    {

        private IRepository<Record> _repository; 

        [SetUp]
        public void Setup()
        {
            var factory = new ConnectionFactory();
            _repository = new Repository<Record>(factory.CreateContext());
        }

        [Test]
        public void CanSaveAndReadRecord()
        {
            // Arrange
            var record = new Record()
            {
                Name = "test"
            };

            // Act
            _repository.Create(record);

            // Assert
            var count = _repository.Filter().ToList().Count;

            Assert.That(count, Is.EqualTo(1));
        }

        [Test]
        public void CanDeleteRecord()
        {
            // Arrange
            var record = new Record()
            {
                Name = "test"
            };

            _repository.Create(record);

            var count = _repository.Filter().ToList().Count;

            Assert.That(count, Is.EqualTo(1));

            // Act
            _repository.Delete(record);

            // Asset
            count = _repository.Filter().ToList().Count;

            Assert.That(count, Is.EqualTo(0));
        }
    }
}