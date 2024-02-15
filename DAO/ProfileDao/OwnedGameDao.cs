using Slush.Data;
using Slush.Entity.Profile;

namespace Slush.DAO.ProfileDao
{
    public class OwnedGameDao
    {
        private readonly DataContext _context;

        public OwnedGameDao(DataContext context)
        {
            _context = context;
        }

        public List<OwnedGame> GetAll()
        {
            return _context.dbOwnedGames.ToList();
        }

        public void Add(OwnedGame game)
        {
            _context.dbOwnedGames.Add(game);
            _context.SaveChanges();
        }
    }
}
