using Slush.Data;
using Slush.Data.Entity;
using Slush.Entity.Store.Product.Creators;

namespace Slush.DAO.LanguageDao
{
    public class LanguageDao
    {
        private readonly DataContext _context;

        public LanguageDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<Language> GetAll()
        {
            return _context.dbLanguages.ToList();
        }

        public void Add(Language language)
        {
            _context.dbLanguages.Add(language);
            _context.SaveChanges();
        }
    }
}
