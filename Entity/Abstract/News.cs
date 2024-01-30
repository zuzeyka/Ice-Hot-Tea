namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class News
    {
        public string id { get; set; }
        public string content {  get; set; }
        public List<string> images { get; set; }
        public int likesCount { get; set; }
        public int dislikesCount { get; set; }
        public string discussionLink { get; set; } // переработать после создания entity для форума
    }
}
