using Slush.Data;
using Slush.Entity.Store.Product;

namespace Slush.DAO.GameInShopDao
{
    public class GameInShopDao
    {
        private readonly DataContext _context;

        public GameInShopDao(DataContext context)
        {
            _context = context;
        }

        public List<GameInShop> GetAll()
        {
            return _context.dbGamesInShops.ToList();
        }

        public void Add(GameInShop game)
        {
            _context.dbGamesInShops.Add(game);
            _context.SaveChanges();
        }
    }
}
