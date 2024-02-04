using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Data.Entity.Community.GameGroup
{
    public class GameComment : DBRecord
    {
        public String gamePostId { get; set; }
        public String content { get; set; }

        public GameComment(String id, String gamePostId, String content, DateTime createdAt)
        {
            this.id = id;
            this.gamePostId = gamePostId;
            this.content = content;
            this.createdAt = createdAt;
        }
    }
}
