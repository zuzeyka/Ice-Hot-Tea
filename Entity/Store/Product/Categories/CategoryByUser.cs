namespace Slush.Data.Entity
{
    public class CategoryByUser : Categories
    {
        public CategoryByUser() { }
        public CategoryByUser(Guid id,
                              String name,
                              String description,
                              DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.createdAt = createdAt;
        }
    }
}
