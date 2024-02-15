using Slush.Data.Entity;
using Slush.Data;

namespace Slush.DAO.CategoriesDao
{
    public class CategoriesByAuthorDao
    {
        private readonly DataContext _context;

        public CategoriesByAuthorDao(DataContext context)
        {
            _context = context;
        }

        public List<CategoryByAuthor> GetAll()
        {
            return _context.dbCategoriesByAuthors.ToList();
        }

        public void Add(CategoryByAuthor category)
        {
            _context.dbCategoriesByAuthors.Add(category);
            _context.SaveChanges();
        }
    }
}
