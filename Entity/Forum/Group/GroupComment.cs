using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community
{
    public class GroupComment
    {
        public String id { get; set; }
        public String groupId { get; set; }
        public String content { get; set; }
        public Guid userId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
