using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Data.Entity
{
    public class SystemRequirement : DBRecord
    {
        protected String gameId { get; set; }
        protected String OS { get; set; }
        protected String processor { get; set; }
        protected String RAM { get; set; }
        protected String video { get; set; }
        protected String freeDiskSpace { get; set; }
    }
}
