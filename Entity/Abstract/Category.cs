namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class Category : DBRecord
    {
        protected String id { get; set; }
        protected String attachedId { get; set; }
        protected String name { get; set; }
        protected String description { get; set; }
        protected DateTime createdAt { get; set; }
        protected DateTime? deleteAt { get; set; }
    }
}
