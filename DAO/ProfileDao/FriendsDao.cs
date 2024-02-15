using Slush.Data.Entity.Community;
using Slush.Data;
using Slush.Entity.Profile;

namespace Slush.DAO.ProfileDao
{
    public class FriendsDao
    {
        private readonly DataContext _context;

        public FriendsDao(DataContext context)
        {
            _context = context;
        }

        public List<Friends> GetAll()
        {
            return _context.dbFriends.ToList();
        }

        public void Add(Friends friend)
        {
            _context.dbFriends.Add(friend);
            _context.SaveChanges();
        }
    }
}
