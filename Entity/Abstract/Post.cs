namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class Post : BDRecord
    {
        public string title { get; set; }
        public string? description { get; set; }
        public int likesCount { get; set; }
        public int dislikesCount { get; set; }
        public string discussionId { get; set; }
        public string gameId { get; set; }
        public string authorId { get; set; }
    }
}
