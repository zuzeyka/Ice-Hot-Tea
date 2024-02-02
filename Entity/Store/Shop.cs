using Ice_Hot_Tea.Data.Entity;
using Ice_Hot_Tea.Entity.Abstract;
using Ice_Hot_Tea.Entity.Store.Product.Creators;

namespace Ice_Hot_Tea.Entity.Store
{
    public class Shop
    {
        public List<Game> popularGames {  get; set; }
        public List<Publisher> popularPublishers { get; set; }
    }
}
