using Slush.Data.Entity.Profile;
using Slush.Data;

namespace Slush.DAO.ProfileDao
{
    public class UserDao
    {
        private readonly DataContext _context;

        public UserDao(DataContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.dbUsers.ToList();
        }

        public void Add(User user)
        {
            _context.dbUsers.Add(user);
            _context.SaveChanges();
        }
    }
}
