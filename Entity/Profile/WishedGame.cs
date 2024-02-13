﻿using Slush.Entity.Abstract;

namespace Slush.Entity.Profile
{
    public class WishedGame :ProfileGame
    {
        public WishedGame() { }
        public WishedGame(Guid id,
                          string ownedGameId,
                          string userId,
                          DateTime createdAt)
        {
            this.id = id;
            this.ownedGameId = ownedGameId;
            this.userId = userId;
            this.createdAt = createdAt;
        }
    }
}
