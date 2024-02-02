namespace WebApplication1.Data.Entitty.Community.GameGroup
{
    public class GameScreenshot
    {
        public String id { get; set; }
        public String gameId { get; set; }
        public String screenshotUrl { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public GameScreenshot(String id, String gameId, String screenshotUrl, DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.screenshotUrl = screenshotUrl;
            this.createdAt = createdAt;
        }
    }
}
