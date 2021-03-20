using System;

namespace GenericRepository
{
    public class Release : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public int Year { get; set; }
        public ReleaseType ReleaseType {get; set; }
    }

    public enum ReleaseType
    {
        Single = 0,
        EP = 1,
        Album = 2
    }
}
