using Slush.Data;
using Slush.Data.Entity.Community;

namespace Slush.DAO.GroupDao
{
    public class GroupCommentDao
    {
        private readonly DataContext _context;

        public GroupCommentDao(DataContext context)
        {
            _context = context;
        }

        public List<GroupComment> GetAll()
        {
            return _context.dbGroupComments.ToList();
        }

        public void Add(GroupComment comment)
        {
            _context.dbGroupComments.Add(comment);
            _context.SaveChanges();
        }
    }
}
