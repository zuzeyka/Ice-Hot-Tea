using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Data.Entity.Community.GameGroup
{
    public class GameNews : DBRecord
    {
        public String gameId { get; set; }
        public String title { get; set; }
        public String content { get; set; }

        public GameNews(String id, String gameId, String title, String content, DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.title = title;
            this.content = content;
            this.createdAt = createdAt;
        }
    }
}
