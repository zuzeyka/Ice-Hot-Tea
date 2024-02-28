using Slush.Data.Entity;
using Slush.Data;
using Slush.Entity.Store.Product.Creators;

namespace Slush.DAO.CreatorsDao
{
    public class PublisherDao
    {
        private readonly DataContext _context;

        public PublisherDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<Publisher> GetAll()
        {
            return _context.dbPublishers.ToList();
        }

        public void Add(Publisher publisher)
        {
            _context.dbPublishers.Add(publisher);
            _context.SaveChanges();
        }
    }
}
