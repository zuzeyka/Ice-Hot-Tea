using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Profile
{
    public class Screenshot : Post
    {
        public String screenshotUrl { get; set; }

        public Screenshot(String id,
                         String authorId,
                         String gameId,
                         String discussionId,
                         int dislikesCount,
                         int likesCount,
                         String? description,
                         String screenshotUrl,
                         String title,
                         DateTime createdAt)
        {
            this.id = id;
            this.likesCount = likesCount;
            this.gameId = gameId;
            this.authorId = authorId;
            this.screenshotUrl = screenshotUrl;
            this.discussionId = discussionId;
            this.dislikesCount = dislikesCount;
            this.description = description;
            this.title = title;
            this.createdAt = createdAt;
        }
    }
}
