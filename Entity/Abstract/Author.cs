namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class Author
    {
        public string id { get; set; }
        public string name { get; set; }
        public string? urlForNewsPage { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
        public Author()
        {
        }
    }
}
