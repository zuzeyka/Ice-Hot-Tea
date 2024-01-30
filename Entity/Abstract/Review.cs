namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class Review
    {
        public bool isPositive { get; set; }
        public string authorId { get; set; }
        public string description { get; set; }
        public int counterOfPositiveMarks { get; set; }
        public int counterOfNegativeMarks { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? deleteAt { get; set; }
    }
}
