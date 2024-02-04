using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Data.Entity.Community.GameGroup
{
    public class GameVideo : DBRecord
    {
        public String gameId { get; set; }
        public String videoUrl { get; set; }

        public GameVideo(String id, String gameId, String videoUrl, DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.videoUrl = videoUrl;
            this.createdAt = createdAt;
        }
    }
}
