using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community
{
    public class Topic : Category
    {
        public String attachedId { get; set; }

        public Guid authorId { get; set; }

        public Topic(String id,
                     String name,
                     String description,
                     String attachedId,
                     DateTime createdAt,
                     Guid authorId)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.attachedId = attachedId;
            this.createdAt = createdAt;
            this.authorId = authorId;
        }

        public List<Post> posts { get; set; } = null!;

    }
}
