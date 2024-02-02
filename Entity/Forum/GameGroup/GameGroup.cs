using Ice_Hot_Tea.Entity.Store.Product;

namespace Ice_Hot_Tea.Data.Entity.Community.GameGroup
{
    public class GameGroup
    {
        public String id { get; set; }
        public GameInShop game { get; set; }
        public List<GameNews> news { get; set; }
        public List<GameVideo> videos { get; set; }
        public List<GameScreenshot> screenshots { get; set; }
        public List<GameTopic> topics { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }

        public GameGroup(String id, GameInShop game, List<GameNews> news, List<GameVideo> videos, List<GameScreenshot> screenshots, List<GameTopic> topics, DateTime createdAt)
        {
            this.id = id;
            this.game = game;
            this.news = news;
            this.videos = videos;
            this.screenshots = screenshots;
            this.topics = topics;
            this.createdAt = createdAt;
        }

    }
}
