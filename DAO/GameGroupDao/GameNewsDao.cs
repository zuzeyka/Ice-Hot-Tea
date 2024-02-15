using Slush.Data.Entity.Community.GameGroup;
using Slush.Data;

namespace Slush.DAO.GameGroupDao
{
    public class GameNewsDao
    {
        private readonly DataContext _context;

        public GameNewsDao(DataContext context)
        {
            _context = context;
        }

        public List<GameNews> GetAll()
        {
            return _context.dbGameNews.ToList();
        }

        public void Add(GameNews news)
        {
            _context.dbGameNews.Add(news);
            _context.SaveChanges();
        }
    }
}
