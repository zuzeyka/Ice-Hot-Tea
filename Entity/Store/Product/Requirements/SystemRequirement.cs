namespace Ice_Hot_Tea.Data.Entity
{
    public class SystemRequirement
    {
        protected String id { get; set; }
        protected String gameId { get; set; }
        protected String OS { get; set; }
        protected String processor { get; set; }
        protected String RAM { get; set; }
        protected String video { get; set; }
        protected String freeDiskSpace { get; set; }
        protected DateTime createdAt { get; set; }
        protected DateTime? deleteAt { get; set; }
    }
}
