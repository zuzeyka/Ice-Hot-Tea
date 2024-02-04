using Ice_Hot_Tea.Data.Entity.Profile;
using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Data.Entity.Community
{
    public class Topic : Category
    {
        public String attachedId { get; set; }

        public User author { get; set; }
        public List<Post> posts { get; set; }

        public Topic(String id, String name, String description, String attachedId, DateTime createdAt, User author, List<Post> posts)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.attachedId = attachedId;
            this.createdAt = createdAt;
            this.author = author;
            this.posts = posts;
        }
    }
}
