using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community
{
    public class Group
    {

        public String id { get; set; }
        public String attachedId { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
        public virtual List<User> users { get; set; }               = null!;
        public virtual List<Topic> topics { get; set; }             = null!;
        public virtual List<GroupComment> comments { get; set; } = null!;
    }
}
