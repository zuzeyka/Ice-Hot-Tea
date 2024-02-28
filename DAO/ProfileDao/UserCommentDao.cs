using Slush.Data.Entity.Profile;
using Slush.Data;

namespace Slush.DAO.ProfileDao
{
    public class UserCommentDao
    {
        private readonly DataContext _context;

        public UserCommentDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<UserComment> GetAll()
        {
            return _context.dbUserComments.ToList();
        }

        public void Add(UserComment comment)
        {
            _context.dbUserComments.Add(comment);
            _context.SaveChanges();
        }
    }
}
