using Slush.Data.Entity;
using Slush.Data;

namespace Slush.DAO.CategoriesDao
{
    public class CategoriesDAO
    {
        private readonly DataContext _context;

        public CategoriesDAO(DataContext context)
        {
            _context = context;
        }

        public virtual List<Categories> GetAll()
        {
            return _context.dbCategories.ToList();
        }

        public void Add(Categories category)
        {
            _context.dbCategories.Add(category);
            _context.SaveChanges();
        }
    }
}
