using Slush.Data;
using Slush.Data.Entity.Community.GameGroup;
using Slush.Entity.Store.Product;

namespace Slush.DAO.GameGroupDao
{
    public class GameCommentDao
    {
        private readonly DataContext _context;

        public GameCommentDao(DataContext context)
        {
            _context = context;
        }

        public List<GameComment> GetAll()
        {
            return _context.dbGameComments.ToList();
        }

        public void Add(GameComment comment)
        {
            _context.dbGameComments.Add(comment);
            _context.SaveChanges();
        }
    }
}
