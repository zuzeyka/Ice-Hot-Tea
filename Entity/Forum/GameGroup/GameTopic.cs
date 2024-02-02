using Ice_Hot_Tea.Data.Entity.Profile;

namespace Ice_Hot_Tea.Data.Entity.Community.GameGroup
{
    public class GameTopic
    {
        public String id { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public String gameGroupId { get; set; }
        public List<GamePosts> posts { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public GameTopic(string id, string name, string description, string gameGroupId, List<GamePosts> posts, DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.gameGroupId = gameGroupId;
            this.posts = posts;
            this.createdAt = createdAt;
        }
    }
}
