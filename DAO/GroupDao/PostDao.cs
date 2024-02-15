using Slush.Data;
using Slush.Data.Entity.Community;

namespace Slush.DAO.GroupDao
{
    public class PostDao
    {
        private readonly DataContext _context;

        public PostDao(DataContext context)
        {
            _context = context;
        }

        public List<Post> GetAll()
        {
            return _context.dbPosts.ToList();
        }

        public void Add(Post post)
        {
            _context.dbPosts.Add(post);
            _context.SaveChanges();
        }
    }
}
