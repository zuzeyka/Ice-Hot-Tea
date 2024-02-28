using Slush.Data.Entity;
using Slush.Data;

namespace Slush.DAO.LanguageDao
{
    public class LanguageInGameDao
    {
        private readonly DataContext _context;

        public LanguageInGameDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<LanguageInGame> GetAll()
        {
            return _context.dbLanguagesInGame.ToList();
        }

        public void Add(LanguageInGame language)
        {
            _context.dbLanguagesInGame.Add(language);
            _context.SaveChanges();
        }
    }
}
