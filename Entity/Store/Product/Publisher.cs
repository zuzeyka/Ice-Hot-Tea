namespace Ice_Hot_Tea.Entity.Store.Product
{
    public class Publisher
    {
        public string id { get; set; }
        public string name { get; set; }
        public string? urlForNewsPage { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
        public Publisher()
        {
        }
    }
}
