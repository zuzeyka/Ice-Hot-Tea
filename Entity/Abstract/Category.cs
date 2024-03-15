namespace Slush.Entity.Abstract
{
    public abstract class Category : DBRecord
    {
        public String attachedId { get; set; }
        public String name { get; set; }
        public String description { get; set; }
    }
}
