using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Data.Entity
{
    public class CategoryForGame : DBRecord
    {
        public String gameId { get; set; }
        public String categoryId { get; set; }


        public CategoryForGame(String id, String gameId, String categoryId, DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.categoryId = categoryId;
            this.createdAt = createdAt;
        }
    }
}
