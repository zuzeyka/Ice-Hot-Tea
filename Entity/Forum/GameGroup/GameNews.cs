namespace Slush.Data.Entity.Community.GameGroup
{
    public class GameNews : Slush.Entity.Abstract.Post
    {
        public String content { get; set; }

        public GameNews(String id,
                         String authorId,
                         String gameId,
                         String discussionId,
                         int dislikesCount,
                         int likesCount,
                         String? description,
                         String gameGroupId,
                         String title,
                         String content,
                         DateTime createdAt)
        {
            this.id = id;
            this.likesCount = likesCount;
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
