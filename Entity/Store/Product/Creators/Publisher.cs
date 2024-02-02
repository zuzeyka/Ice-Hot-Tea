namespace Ice_Hot_Tea.Data.Entity
{
    public class Publisher
    {
        public String id { get; set; }
        public String name { get; set; }
        public String? urlForNewsPage { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
        public Publisher(String id, String name, String? urlForNewsPage, DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.urlForNewsPage = urlForNewsPage;
            this.createdAt = createdAt;
        }
    }
}
