using Slush.Data.Entity;
using Slush.Data;
using Slush.Entity.Store.Product;

namespace Slush.DAO.GameInShopDao
{
    public class DLCInShopDao
    {
        private readonly DataContext _context;

        public DLCInShopDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<DLCInShop> GetAll()
        {
            return _context.dbDLCsInShop.ToList();
        }

        public void Add(DLCInShop dlc)
        {
            _context.dbDLCsInShop.Add(dlc);
            _context.SaveChanges();
        }
    }
}
