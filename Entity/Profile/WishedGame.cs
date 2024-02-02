using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Entity.Profile
{
    public class WishedGame :ProfileGame
    {
        public WishedGame(string id, string ownedGameId, string userId, DateTime createdAt)
        {
            this.id = id;
            this.ownedGameId = ownedGameId;
            this.userId = userId;
            this.createdAt = createdAt;
        }
    }
}
