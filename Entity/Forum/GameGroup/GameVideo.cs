namespace WebApplication1.Data.Entitty.Community.GameGroup
{
    public class GameVideo
    {
        public String id { get; set; }
        public String gameId { get; set; }
        public String videoUrl { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public GameVideo(String id, String gameId, String videoUrl, DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.videoUrl = videoUrl;
            this.createdAt = createdAt;
        }
    }
}
