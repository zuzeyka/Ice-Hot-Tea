using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Data.Entity.Community.GameGroup
{
    public class GameGuide : DBRecord
    {
        public String gameGroupId { get; set; }
        public String title { get; set; }
        public String content { get; set; }

        public GameGuide(String id, String gameGroupId, String title, String content, DateTime createdAt)
        {
            this.id = id;
            this.gameGroupId = gameGroupId;
            this.title = title;
            this.content = content;
            this.createdAt = createdAt;
        }
    }
}
