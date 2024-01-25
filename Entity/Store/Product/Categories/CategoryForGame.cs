namespace Ice_Hot_Tea.Entity.Store.Product.Categories
{
    public class CategoryForGame
    {
        public string id { get; set; }
        public string gameId { get; set; }
        public string categoryId { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }

        public CategoryForGame()
        {
        }
    }
}
