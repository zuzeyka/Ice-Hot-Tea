using Ice_Hot_Tea.Data.Entity.Profile;
using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Data.Entity.Community
{
    public class GroupComment : DBRecord
    {
        public String groupId { get; set; }
        public String content { get; set; }


        public GroupComment(String id, String content, DateTime createdAt, String userId, String groupId)
        {
            this.id = id;
            this.content = content;
            this.createdAt = createdAt;
            this.groupId = groupId;
        }
    }
}
