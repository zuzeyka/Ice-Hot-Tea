using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community
{
    public class GroupComment : DBRecord
    {
        public String groupId { get; set; }
        public String content { get; set; }

        public GroupComment() { }
        public GroupComment(Guid id,
                            String content,
                            DateTime createdAt,
                            String userId,
                            String groupId)
        {
            this.id = id;
            this.content = content;
            this.createdAt = createdAt;
            this.groupId = groupId;
        }
    }
}
