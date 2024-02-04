using Ice_Hot_Tea.Data.Entity.Profile;

namespace Ice_Hot_Tea.Data.Entity.Community
{
    public class Post : Ice_Hot_Tea.Entity.Abstract.Post
    {
        public String content { get; set; }

        public Post(String id, String authorId, String? description, String gameId, String content, String discussionId, DateTime createdAt, int likesCount, int dislikesCount)
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
