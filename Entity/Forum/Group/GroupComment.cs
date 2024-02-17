using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community
{
    public class GroupComment : DBRecord
    {
        public String groupId { get; set; }
        public String content { get; set; }
        public Guid userId { get; set; }

        public GroupComment(String id,
                            String content,
                            DateTime createdAt,
                            Guid userId,
                            String groupId)
        {
            this.id = id;
            this.content = content;
            this.createdAt = createdAt;
            this.userId = userId;
            this.groupId = groupId;
        }
    }
}
