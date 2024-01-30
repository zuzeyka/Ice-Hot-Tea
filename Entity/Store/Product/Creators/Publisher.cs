using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Entity.Store.Product.Creators
{
    public class Publisher : Profile
    {
        public List<News> news { get; set; }
        public List<Game> games { get; set; }
    }
}
