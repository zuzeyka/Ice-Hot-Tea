namespace Slush.Entity.Abstract
{
    public abstract class Post : DBRecord
    {
        public String title { get; set; }
        public String? description { get; set; }
        public int likesCount { get; set; }
        public int dislikesCount { get; set; }
        public String discussionId { get; set; }
        public String gameId { get; set; }
        public String authorId { get; set; }
    }
}
