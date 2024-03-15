namespace Slush.Entity.Abstract
{
    public abstract class DBRecord
    {
        public String id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
