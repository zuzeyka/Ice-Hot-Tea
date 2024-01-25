using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Entity.Store.Product
{
    public class ReviewByGame
    {
        public string id { get; set; }
        public string gameId { get; set; }
        public bool isPositive { get; set; }
        public Author author { get; set; }
        public string description { get; set; }
        public int counterOfPositiveMarks { get; set; }
        public int counterOfNegativeMarks { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
