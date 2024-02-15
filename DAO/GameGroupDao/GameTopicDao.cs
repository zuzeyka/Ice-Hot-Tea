using Slush.Data.Entity.Community.GameGroup;
using Slush.Data;

namespace Slush.DAO.GameGroupDao
{
    public class GameTopicDao
    {
        private readonly DataContext _context;

        public GameTopicDao(DataContext context)
        {
            _context = context;
        }

        public List<GameTopic> GetAll()
        {
            return _context.dbGameTopics.ToList();
        }

        public void Add(GameTopic topics)
        {
            _context.dbGameTopics.Add(topics);
            _context.SaveChanges();
        }
    }
}
