namespace Slush.Entity.Abstract
{
    public abstract class Author : DBRecord
    {
        public int subscribersCount { get; set; }
    }
}
