using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;
using Slush.Entity.Store.Product;

namespace Slush.Data.Entity.Community.GameGroup
{
    public class GameGroup : DBRecord
    {
        public String gameId { get; set; }

        public GameGroup(String id,
                         String gameId,
                         DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.createdAt = createdAt;
        }

        public List<GameNews> news { get; set; }                = null!;
        public List<Video> videos { get; set; }                 = null!;
        public List<Screenshot> screenshots { get; set; }       = null!;
        public List<GameTopic> topics { get; set; } = null!;
    }
}
