using Slush.Entity.Abstract;

namespace Slush.Data.Entity
{
    public class SystemRequirement : DBRecord
    {
        public SystemRequirement() { }
        protected String gameId { get; set; }
        protected String OS { get; set; }
        protected String processor { get; set; }
        protected String RAM { get; set; }
        protected String video { get; set; }
        protected String freeDiskSpace { get; set; }
    }
}
