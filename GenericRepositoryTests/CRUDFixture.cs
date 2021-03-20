using System.Linq;
using GenericRepository;
using NUnit.Framework;

namespace GenericRepositoryTests
{
    [TestFixture]
    public class CRUDFixtures
    {

        private IRepository<Release> _repository; 

        [SetUp]
        public void Setup()
        {
            var factory = new ConnectionFactory();
            _repository = new Repository<Release>(factory.CreateContext());
        }

        [Test]
        public void CanSaveAndReadRecord()
        {
            // Arrange
            var record = new Release()
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
            var record = new Release()
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

        [Test]
        public void CanUpdateRecord()
        {
            // Arrange
            var record = new Release()
            {
                Name = "test"
            };

            _repository.Create(record);

            // Act
            record.Name = "test 2";

            // Assert
            var record2 = _repository.GetById(record.Id);

            Assert.That(record2, Is.Not.Null);
            Assert.That(record2.Name, Is.EqualTo("test 2"));
        }

        [Test]
        public void CanDeleteById()
        {
            // Arrange
            var record1 = new Release()
            {
                Name = "test"
            };

            var record2 = new Release()
            {
                Name = "test2"
            };

            _repository.Create(record1);
            _repository.Create(record2);

            // Act
            _repository.Delete(record1.Id);

            // Assert
            var count = _repository.Filter().Count();

            Assert.That(count, Is.EqualTo(1));
        }

        [Test]
        public void CanFilterWithPredicate()
        {
            // Arrange
            var record1 = new Release()
            {
                Name = "test"
            };

            var record2 = new Release()
            {
                Name = "test2"
            };

            _repository.Create(record1);
            _repository.Create(record2);

            // Act
            var result = _repository.Filter().First(x => x.Name.Equals("test2"));

            // Assert
            Assert.That(result.Name, Is.EqualTo("test2"));
        }
    }
}