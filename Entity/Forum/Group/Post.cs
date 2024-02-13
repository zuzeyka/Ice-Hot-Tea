using Slush.Data.Entity.Profile;

namespace Slush.Data.Entity.Community
{
    public class Post : Slush.Entity.Abstract.Post
    {
        public String content { get; set; }

        public Post() { }

        public Post(Guid id,
                    String authorId,
                    String? description,
                    String gameId,
                    String content,
                    String discussionId,
                    DateTime createdAt,
                    int likesCount,
                    int dislikesCount)
        {
            this.id = id;
            this.authorId = authorId;
            this.content = content;
            this.description = description;
            this.discussionId = discussionId;
            this.createdAt = createdAt;
            this.likesCount = likesCount;
            this.dislikesCount = dislikesCount;
            this.gameId = gameId;
        }
    }
}
