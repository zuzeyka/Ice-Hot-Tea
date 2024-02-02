namespace Ice_Hot_Tea.Data.Entity
{
    public class CategoryByUser : Categories
    {
        public CategoryByUser(String id, String name, String description, DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.createdAt = createdAt;
        }
    }
}
