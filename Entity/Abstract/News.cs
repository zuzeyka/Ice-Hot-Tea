namespace Slush.Entity.Abstract
{
    public abstract class News : Post
    {
        public virtual List<String> images { get; set; }
    }
}
