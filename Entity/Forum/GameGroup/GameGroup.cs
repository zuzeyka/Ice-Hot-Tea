using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;
using Slush.Entity.Store.Product;

namespace Slush.Data.Entity.Community.GameGroup
{
    public class GameGroup
    {
        public String id { get; set; }
        public String gameId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }

        public virtual List<GameNews> news { get; set; }                = null!;
        public virtual List<Video> videos { get; set; }                 = null!;
        public virtual List<Screenshot> screenshots { get; set; }       = null!;
        public virtual List<GameTopic> topics { get; set; } = null!;
    }
}
