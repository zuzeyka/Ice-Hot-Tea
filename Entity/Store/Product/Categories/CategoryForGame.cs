using Slush.Entity.Abstract;

namespace Slush.Data.Entity
{
    public class CategoryForGame
    {
        public String id { get; set; }
        public String gameId { get; set; }
        public String categoryId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }

    }
}
