using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community
{
    public class Group : Category
    {

        public Group(String id,
                     String name,
                     String description,
                     DateTime createdAt,
                     DateTime? deleteAt)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.createdAt = createdAt;
            this.deleteAt = deleteAt;
        }
        public List<User> users { get; set; }               = null!;
        public List<Topic> topics { get; set; }             = null!;
        public List<GroupComment> comments { get; set; } = null!;
    }
}
