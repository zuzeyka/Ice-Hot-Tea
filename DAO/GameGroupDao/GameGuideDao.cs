using Slush.Data.Entity.Community.GameGroup;
using Slush.Data;

namespace Slush.DAO.GameGroupDao
{
    public class GameGuideDao
    {
        private readonly DataContext _context;

        public GameGuideDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<GameGuide> GetAll()
        {
            return _context.dbGameGuides.ToList();
        }

        public void Add(GameGuide guide)
        {
            _context.dbGameGuides.Add(guide);
            _context.SaveChanges();
        }
    }
}
