using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community.GameGroup
{
    public class GameTopic : Category
    {
        public List<GamePosts> posts { get; set; }

        public GameTopic(string id,
                         string name,
                         string description,
                         string attachedId,
                         List<GamePosts> posts,
                         DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.attachedId = attachedId;
            this.posts = posts;
            this.createdAt = createdAt;
        }
    }
}
