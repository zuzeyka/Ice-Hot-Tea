using Slush.Data;
using Slush.Entity.Profile;

namespace Slush.DAO.ProfileDao
{
    public class WishedGameDao
    {
        private readonly DataContext _context;

        public WishedGameDao(DataContext context)
        {
            _context = context;
        }

        public List<WishedGame> GetAll()
        {
            return _context.dbWishedGames.ToList();
        }

        public void Add(WishedGame game)
        {
            _context.dbWishedGames.Add(game);
            _context.SaveChanges();
        }
    }
}
