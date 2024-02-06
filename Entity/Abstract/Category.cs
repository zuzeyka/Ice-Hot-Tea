namespace Slush.Entity.Abstract
{
    public abstract class Category : DBRecord
    {
        protected String attachedId { get; set; }
        protected String name { get; set; }
        protected String description { get; set; }
    }
}
