using Slush.Entity.Abstract;

namespace Slush.Data.Entity
{
    public class Categories
    {
        public String id { get; set; }
        public String name { get; set; }
        public String description { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }

}
    