using Ice_Hot_Tea.Data.Entitty.Profile;

namespace Ice_Hot_Tea.Data.Entitty.Community
{
    public class Post
    {
        public String id { get; set; }
        public User author { get; set; }
        public String content { get; set; }
        public String topicId { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public Post(String id, User author, String content, String topicId, DateTime createdAt)
        {
            this.id = id;
            this.author = author;
            this.content = content;
            this.topicId = topicId;
            this.createdAt = createdAt;
        }
    }
}
