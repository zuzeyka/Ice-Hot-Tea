namespace Slush.Entity.Store.Product.Creators
{
    public class Author
    {
        public String id { get; set; }
        public int subscribersCount { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
