using Slush.Entity.Abstract;

namespace Slush.Entity.Forum
{
    public class Forum
    {
        public virtual List<Post> forumFeed {  get; set; }
    }
}
