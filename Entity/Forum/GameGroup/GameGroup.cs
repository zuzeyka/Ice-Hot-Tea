using Slush.Data.Entity.Profile;
using Slush.Entity.Abstract;
using Slush.Entity.Store.Product;

namespace Slush.Data.Entity.Community.GameGroup
{
    public class GameGroup : DBRecord
    {
        public GameInShop game { get; set; }
        public List<GameNews> news { get; set; }
        public List<Video> videos { get; set; }
        public List<Screenshot> screenshots { get; set; }
        public List<GameTopic> topics { get; set; }

        public GameGroup(String id,
                         GameInShop game,
                         List<GameNews> news,
                         List<GameVideo> videos,
                         List<GameScreenshot> screenshots,
                         List<GameTopic> topics,
                         DateTime createdAt)
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
