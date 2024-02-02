namespace Ice_Hot_Tea.Data.Entitty
{
    public class CategoryForGame
    {
        public String id { get; set; }
        public String gameId { get; set; }
        public String categoryId { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }

        public CategoryForGame(String id, String gameId, String categoryId, DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.categoryId = categoryId;
            this.createdAt = createdAt;
        }
    }
}
