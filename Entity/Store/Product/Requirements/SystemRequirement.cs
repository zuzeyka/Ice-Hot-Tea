using Slush.Entity.Abstract;

namespace Slush.Data.Entity
{
    public class SystemRequirement
    {
        public String id { get; set; }
        public String gameId { get; set; }
        public String OS { get; set; }
        public String processor { get; set; }
        public String RAM { get; set; }
        public String video { get; set; }
        public String freeDiskSpace { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
