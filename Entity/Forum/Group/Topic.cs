using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community
{
    public class Topic
    {
        public String id { get; set; }
        public String attachedId { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public Guid authorId { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
        public virtual List<Post> posts { get; set; } = null!;

    }
}
