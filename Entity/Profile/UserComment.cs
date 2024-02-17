using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Profile
{
    public class UserComment : DBRecord
    {
        public String userId { get; set; }
        public Guid authorId { get; set; }
        public String content { get; set; }

        public UserComment(String id,
                           Guid authorId,
                           String content,
                           DateTime createdAt,
                           String userId)
        {
            this.id = id;
            this.authorId = authorId;
            this.content = content;
            this.createdAt = createdAt;
            this.userId = userId;
        }
    }
}
