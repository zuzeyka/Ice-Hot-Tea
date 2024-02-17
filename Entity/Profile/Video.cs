using Slush.Entity.Abstract;

namespace Slush.Data.Entity.Profile
{
    public class Video : Post
    {
        public String videoUrl { get; set; }

        public Video(String id,
                         String authorId,
                         String gameId,
                         String discussionId,
                         int dislikesCount,
                         int likesCount,
                         String? description,
                         String videoUrl,
                         String title,
                         DateTime createdAt)
        {
            this.id = id;
            this.likesCount = likesCount;
            this.gameId = gameId;
            this.authorId = authorId;
            this.videoUrl = videoUrl;
            this.discussionId = discussionId;
            this.dislikesCount = dislikesCount;
            this.description = description;
            this.title = title;
            this.createdAt = createdAt;
        }
    }
}
