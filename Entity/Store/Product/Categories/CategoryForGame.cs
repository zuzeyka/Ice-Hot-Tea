using Slush.Entity.Abstract;

namespace Slush.Data.Entity
{
    public class CategoryForGame : DBRecord
    {
        public String gameId { get; set; }
        public String categoryId { get; set; }


        public CategoryForGame(String id,
                               String gameId,
                               String categoryId,
                               DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.categoryId = categoryId;
            this.createdAt = createdAt;
        }
    }
}
