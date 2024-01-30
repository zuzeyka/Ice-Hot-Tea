namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
