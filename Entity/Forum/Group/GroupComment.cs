using Ice_Hot_Tea.Data.Entity.Profile;

namespace Ice_Hot_Tea.Data.Entity.Community
{
    public class GroupComment
    {
        public String id { get; set; }
        public String groupId { get; set; }
        public String content { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public GroupComment(String id, String content, DateTime createdAt, String userId, String groupId)
        {
            this.id = id;
            this.content = content;
            this.createdAt = createdAt;
            this.groupId = groupId;
        }
    }
}
