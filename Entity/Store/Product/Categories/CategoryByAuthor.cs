
namespace Slush.Data.Entity
{
    public class CategoryByAuthor : Categories
    {
        public String image { get; set; }

        public CategoryByAuthor() { }

        public CategoryByAuthor(Guid id,
                                String name,
                                String description,
                                String image,
                                DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.image = image;
            this.createdAt = createdAt;
        }
    }
}
