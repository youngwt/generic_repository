using System;
namespace GenericRepository
{
    public class Record : IRecord
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
