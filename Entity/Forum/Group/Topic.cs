using Ice_Hot_Tea.Data.Entity.Profile;

namespace Ice_Hot_Tea.Data.Entity.Community
{
    public class Topic
    {
        public String id {  get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public Group group { get; set; }

        public User author { get; set; }
        public List<Post> posts { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public Topic(String id, String name, String description, Group group, DateTime createdAt, User author, List<Post> posts)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.group = group;
            this.createdAt = createdAt;
            this.author = author;
            this.posts = posts;
        }
    }
}
