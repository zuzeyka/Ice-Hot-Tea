namespace Slush.Entity.Abstract
{
    public class Author
    {
        public String id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
        public int subscribersCount { get; set; }
    }
}
