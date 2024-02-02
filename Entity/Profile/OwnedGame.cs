using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Entity.Profile
{
    public class OwnedGame : ProfileGame
    {
        public OwnedGame(string id, string ownedGameId, string userId, DateTime createdAt)
        {
            this.id = id;
            this.ownedGameId = ownedGameId;
            this.userId = userId;
            this.createdAt = createdAt;
        }
    }
}
