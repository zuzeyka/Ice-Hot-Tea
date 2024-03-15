using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community.GameGroup
{
    public class GameTopic
    {
        public String id { get; set; }
        public String attachedId { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
        public virtual List<GamePosts> posts { get; set; } = null!; // virtual связи всем поставить !!!!!!!!!
    }
}
