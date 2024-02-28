using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Profile
{
    public class UserComment
    {
        public String id { get; set; }
        public String userId { get; set; }
        public Guid authorId { get; set; }
        public String content { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
