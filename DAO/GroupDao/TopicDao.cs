using Slush.Data;
using Slush.Data.Entity.Community;

namespace Slush.DAO.GroupDao
{
    public class TopicDao
    {
        private readonly DataContext _context;

        public TopicDao(DataContext context)
        {
            _context = context;
        }

        public List<Topic> GetAll()
        {
            return _context.dbTopics.ToList();
        }

        public void Add(Topic topic)
        {
            _context.dbTopics.Add(topic);
            _context.SaveChanges();
        }
    }
}
