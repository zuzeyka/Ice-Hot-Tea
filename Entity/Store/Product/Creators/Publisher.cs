﻿namespace Slush.Entity.Store.Product.Creators
{
    public class Publisher : Abstract.Profile
    {
        public String? urlForNewsPage { get; set; }

        public Publisher() { }
        public Publisher(Guid id,
                         String description,
                         String avatar,
                         String backgroundImage,
                         String name,
                         String? urlForNewsPage,
                         DateTime createdAt,
                         List<object> showcases,
                         DateTime? deleteAt)
        {
            this.id = id;
            this.name = name;
            this.avatar = avatar;
            this.backgroundImage = backgroundImage;
            this.description = description;
            this.urlForNewsPage = urlForNewsPage;
            this.showcases = showcases;
            this.createdAt = createdAt;
            this.deleteAt = deleteAt;
        }
    }
}
