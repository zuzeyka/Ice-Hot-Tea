namespace Ice_Hot_Tea.Entity.Store.Product.Requirements
{
    public class SystemRequirement
    {
        protected string id { get; set; }
        protected string gameId { get; set; }
        protected string OS { get; set; }
        protected string processor { get; set; }
        protected string RAM { get; set; }
        protected string video { get; set; }
        protected string freeDiskSpace { get; set; }
        protected DateTime createdAt { get; set; }
        protected DateTime? deleteAt { get; set; }
    }
}
