using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Entity.Store.Product.Requirements
{
    public abstract class SystemRequirement : BDRecord
    {
        protected string gameId { get; set; }
        protected string? OS { get; set; }
        protected string? CPU { get; set; }
        protected string? RAM { get; set; }
        protected string? GPU { get; set; }
        protected string freeDiskSpace { get; set; }
    }
}
