using System;

namespace GenericRepository
{
    public class Artist : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
