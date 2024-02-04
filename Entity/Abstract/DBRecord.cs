namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class DBRecord
    {
        public string id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
