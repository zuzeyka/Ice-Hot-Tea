namespace Ice_Hot_Tea.Data.Entity.Community.GameGroup
{
    public class GameComment
    {
        public String id { get; set; }
        public String gamePostId { get; set; }
        public String content { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public GameComment(String id, String gamePostId, String content, DateTime createdAt)
        {
            this.id = id;
            this.gamePostId = gamePostId;
            this.content = content;
            this.createdAt = createdAt;
        }
    }
}
