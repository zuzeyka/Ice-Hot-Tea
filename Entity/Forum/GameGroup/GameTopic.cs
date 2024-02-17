using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community.GameGroup
{
    public class GameTopic : Category
    {
        public GameTopic(String id,
                         String name,
                         String description,
                         String attachedId,
                         DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.attachedId = attachedId;
            this.createdAt = createdAt;
        }

        public List<GamePosts> posts { get; set; } = null!;
    }
}
