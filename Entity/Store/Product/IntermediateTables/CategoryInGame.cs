namespace Ice_Hot_Tea.Entity.Store.Product.IntermediateTables
{
    public class CategoryInGame
    {
        public string id { get; set; }
        public string gameId { get; set; }
        public string categoryId { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
