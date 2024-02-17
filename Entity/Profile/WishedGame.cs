using Slush.Entity.Abstract;

namespace Slush.Entity.Profile
{
    public class WishedGame :ProfileGame
    {
        public WishedGame(String id,
                          String ownedGameId,
                          String userId,
                          DateTime createdAt)
        {
            this.id = id;
            this.ownedGameId = ownedGameId;
            this.userId = userId;
            this.createdAt = createdAt;
        }
    }
}
