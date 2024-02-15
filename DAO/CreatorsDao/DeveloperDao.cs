using Slush.Data.Entity;
using Slush.Data;
using Slush.Entity.Store.Product.Creators;

namespace Slush.DAO.CreatorsDao
{
    public class DeveloperDao
    {
        private readonly DataContext _context;

        public DeveloperDao(DataContext context)
        {
            _context = context;
        }

        public List<Developer> GetAll()
        {
            return _context.dbDevelopers.ToList();
        }

        public void Add(Developer developer)
        {
            _context.dbDevelopers.Add(developer);
            _context.SaveChanges();
        }
    }
}
