using Slush.Data.Entity.Community.GameGroup;
using Slush.Data;
using Slush.Data.Entity.Community;

namespace Slush.DAO.GroupDao
{
    public class GroupDao
    {
        private readonly DataContext _context;

        public GroupDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<Group> GetAll()
        {
            return _context.dbGroups.ToList();
        }

        public void Add(Group group)
        {
            _context.dbGroups.Add(group);
            _context.SaveChanges();
        }
    }
}
