namespace WebApplication1.Data.Entitty.Community.GameGroup
{
    public class GameNews
    {
        public String id { get; set; }
        public String gameId { get; set; }
        public String title { get; set; }
        public String content { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public GameNews(String id, String gameId, String title, String content, DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.title = title;
            this.content = content;
            this.createdAt = createdAt;
        }
    }
}
