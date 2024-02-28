using Slush.Data.Entity;
using Slush.Data;
using Slush.Entity.Abstract;

namespace Slush.DAO.CategoriesDao
{
    public class CategoryForGameDao
    {
        private readonly DataContext _context;

        public CategoryForGameDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<CategoryForGame> GetAll()
        {
            return _context.dbCategoriesForGame.ToList();
        }

        public void Add(CategoryForGame category)
        {
            _context.dbCategoriesForGame.Add(category);
            _context.SaveChanges();
        }
    }
}
