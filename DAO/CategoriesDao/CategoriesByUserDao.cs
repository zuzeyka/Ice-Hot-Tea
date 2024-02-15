using Slush.Data.Entity;
using Slush.Data;

namespace Slush.DAO.CategoriesDao
{
    public class CategoriesByUserDao
    {
        private readonly DataContext _context;

        public CategoriesByUserDao(DataContext context)
        {
            _context = context;
        }

        public List<CategoryByUser> GetAll()
        {
            return _context.dbCategoriesByUsers.ToList();
        }

        public void Add(CategoryByUser category)
        {
            _context.dbCategoriesByUsers.Add(category);
            _context.SaveChanges();
        }
    }
}
