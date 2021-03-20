using System;

namespace GenericRepository
{
    public class Song : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public Release Release { get; set; }
    }
}
