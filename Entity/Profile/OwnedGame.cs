using Slush.Entity.Abstract;

namespace Slush.Entity.Profile
{
    public class OwnedGame
    {
        public String id { get; set; }
        public String ownedGameId { get; set; }
        public String userId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
