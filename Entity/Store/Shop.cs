using Slush.Data.Entity;
using Slush.Entity.Abstract;
using Slush.Entity.Store.Product.Creators;

namespace Slush.Entity.Store
{
    public class Shop
    {
        public virtual List<Game> popularGames {  get; set; }           = null!;
        public virtual List<Publisher> popularPublishers { get; set; } = null!;
    }
}
