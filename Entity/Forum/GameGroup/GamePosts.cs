﻿using Slush.Data.Entity.Profile;

namespace Slush.Data.Entity.Community.GameGroup
{
    public class GamePosts : Slush.Entity.Abstract.Post
    {
        public String content { get; set; }
        public List<GameComment> comments { get; set; }

        public GamePosts(String id,
                         String authorId,
                         String gameId,
                         String discussionId,
                         int dislikesCount,
                         int likesCount,
                         String? description,
                         String title,
                         String content,
                         List<GameComment> comments,
                         DateTime createdAt)
        {
            this.id = id;
            this.likesCount = likesCount;
            this.comments = comments;
            this.gameId = gameId;
            this.authorId = authorId;
            this.discussionId = discussionId;
            this.dislikesCount = dislikesCount;
            this.description = description;
            this.title = title;
            this.content = content;
            this.createdAt = createdAt;
        }
    }
}
