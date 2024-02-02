namespace WebApplication1.Data.Entitty.Community.GameGroup
{
    public class GameGuide
    {
        public String id { get; set; }
        public String gameGroupId { get; set; }
        public String title { get; set; }
        public String content { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public GameGuide(String id, String gameGroupId, String title, String content, DateTime createdAt)
        {
            this.id = id;
            this.gameGroupId = gameGroupId;
            this.title = title;
            this.content = content;
            this.createdAt = createdAt;
        }
    }
}
