using Slush.Data.Entity.Community.GameGroup;
using Slush.Data;

namespace Slush.DAO.GameGroupDao
{
    public class GamePostsDao
    {
        private readonly DataContext _context;

        public GamePostsDao(DataContext context)
        {
            _context = context;
        }

        public List<GamePosts> GetAll()
        {
            return _context.dbGamePosts.ToList();
        }

        public void Add(GamePosts posts)
        {
            _context.dbGamePosts.Add(posts);
            _context.SaveChanges();
        }
    }
}
