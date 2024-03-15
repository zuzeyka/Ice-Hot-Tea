using Slush.Data;
using Slush.Data.Entity.Profile;
using Slush.Entity.Profile;

namespace Slush.DAO.ProfileDao
{
    public class ScreenshotDao
    {
        private readonly DataContext _context;

        public ScreenshotDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<Screenshot> GetAll()
        {
            return _context.dbScreenshots.ToList();
        }

        public void Add(Screenshot screenshot)
        {
            _context.dbScreenshots.Add(screenshot);
            _context.SaveChanges();
        }
    }
}
