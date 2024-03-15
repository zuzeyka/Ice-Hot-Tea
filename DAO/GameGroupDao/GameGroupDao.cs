using Slush.Data.Entity.Community.GameGroup;
using Slush.Data;

namespace Slush.DAO.GameGroupDao
{
    public class GameGroupDao
    {
        private readonly DataContext _context;

        public GameGroupDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<GameGroup> GetAll()
        {
            return _context.dbGameGroups.ToList();
        }

        public void Add(GameGroup group)
        {
            _context.dbGameGroups.Add(group);
            _context.SaveChanges();
        }
    }
}
