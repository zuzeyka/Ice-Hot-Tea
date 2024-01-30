using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Entity.Store.Product.IntermediateTables
{
    public class ReviewByGame
    {
        public string id { get; set; }
        public string gameId { get; set; }
        public string AuthorId { get; set; }

        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
