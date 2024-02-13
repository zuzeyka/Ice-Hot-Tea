﻿using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Community.GameGroup
{
    public class GameComment : DBRecord
    {
        public String gamePostId { get; set; }
        public String content { get; set; }
        public Author Author { get; set; }

        public GameComment() { }

        public GameComment(Guid id,
                           String gamePostId,
                           String content,
                           DateTime createdAt)
        {
            this.id = id;
            this.gamePostId = gamePostId;
            this.content = content;
            this.createdAt = createdAt;
        }
    }
}
