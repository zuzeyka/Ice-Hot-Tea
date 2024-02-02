using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Entity.Store.Product.Creators
{
    public class Developer : Profile
    {
        public String id { get; set; }
        public String name { get; set; }
        public String? urlForNewsPage { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
        public Developer(String id, String name, String? urlForNewsPage, DateTime createdAt, DateTime? deleteAt)
        {
            this.id = id;
            this.name = name;
            this.urlForNewsPage = urlForNewsPage;
            this.createdAt = createdAt;
            this.deleteAt = deleteAt;
        }
    }
}
