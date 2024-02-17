using Slush.Data.Entity;
using Slush.Entity.Abstract;
using Slush.Entity.Store.Product.Creators;

namespace Slush.Entity.Store
{
    public class Shop
    {
        public List<Game> popularGames {  get; set; }           = null!;
        public List<Publisher> popularPublishers { get; set; } = null!;
    }
}
