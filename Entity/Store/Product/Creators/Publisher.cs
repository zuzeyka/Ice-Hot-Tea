namespace Slush.Entity.Store.Product.Creators
{
    public class Publisher : Abstract.Profile
    {
        public String? urlForNewsPage { get; set; }

        public Publisher(String id,
                         String description,
                         String avatar,
                         String backgroundImage,
                         String name,
                         String? urlForNewsPage,
                         DateTime createdAt,
                         DateTime? deleteAt)
        {
            this.id = id;
            this.name = name;
            this.avatar = avatar;
            this.backgroundImage = backgroundImage;
            this.description = description;
            this.urlForNewsPage = urlForNewsPage;
            this.createdAt = createdAt;
            this.deleteAt = deleteAt;
        }

        public List<object> showcases { get; set; } = null!;
    }
}
