using Ice_Hot_Tea.Data.Entity.Profile;

namespace Ice_Hot_Tea.Data.Entity.Community.GameGroup
{
    public class GamePosts
    {
        public String id { get; set; }
        public User author { get; set; }
        public String content { get; set; }
        public String gameTopicId { get; set; }
        public List<GameComment> comments { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public GamePosts(String id, User author, String content, String gameTopicId, List<GameComment> comments, DateTime createdAt)
        {
            this.id = id;
            this.author = author;
            this.content = content;
            this.gameTopicId = gameTopicId;
            this.createdAt = createdAt;
            this.comments = comments;
        }
    }
}
