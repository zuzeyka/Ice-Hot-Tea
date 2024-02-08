using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Profile
{
    public class UserComment : DBRecord
    {
        public String userId { get; set; }
        public User author { get; set; }
        public String content { get; set; }


        public UserComment(String id,
                           User author,
                           String content,
                           DateTime createdAt,
                           String userId)
        {
            this.id = id;
            this.author = author;
            this.content = content;
            this.createdAt = createdAt;
            this.userId = userId;
        }
    }
}
