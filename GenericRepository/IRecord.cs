using System;
namespace GenericRepository
{
    public interface IRecord
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
